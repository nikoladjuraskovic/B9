using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace B9Katalog
{
    public partial class katalog : System.Web.UI.Page
    {
        List<Album> sviAlbumi = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(Server.MapPath("katalog.txt"));
            sviAlbumi = Album.ucitaj(r);
            r.Close();

            if (!IsPostBack)
            {
                foreach (Album a in sviAlbumi)
                {
                    if (!DropDownList1.Items.Contains(new ListItem(a.zanr)))
                        DropDownList1.Items.Add(a.zanr);
                    if (!DropDownList2.Items.Contains(new ListItem(a.godina.ToString())))
                        DropDownList2.Items.Add(a.godina.ToString());
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label6.Text = "";
            List<Album> nova = new List<Album>();
            foreach (Album a in sviAlbumi)
            {
                bool ispunjavaUslove = true;

                if (TextBox1.Text != "")
                {
                    if (!a.izvodjac.ToLower().StartsWith(TextBox1.Text.ToLower()))
                        ispunjavaUslove = false;
                }
                if (TextBox2.Text != "")
                {
                    if (!a.naziv.ToLower().StartsWith(TextBox2.Text.ToLower()))
                        ispunjavaUslove = false;
                }
                if (DropDownList1.SelectedValue != "")
                {
                    if (a.zanr != DropDownList1.SelectedValue)
                        ispunjavaUslove = false;
                }
                if (DropDownList2.SelectedValue != "")
                {
                    if (a.godina != int.Parse(DropDownList2.SelectedValue))
                        ispunjavaUslove = false;
                }
                if (TextBox3.Text != "")
                {
                    if (!a.izdavac.ToLower().StartsWith(TextBox3.Text.ToLower()))
                        ispunjavaUslove = false;
                }
                if (ispunjavaUslove)
                    nova.Add(a);
            }
            if (nova.Count > 0)
            {
                GridView1.DataSource = nova;
                GridView1.DataBind();
            }
            else
            {
                Label6.Text = "Ne postoji album koji ispunjava zadate uslove!";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }
    }
}