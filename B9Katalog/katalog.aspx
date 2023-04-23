<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="katalog.aspx.cs" Inherits="B9Katalog.katalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <asp:Label ID="Label1" runat="server" Text="Izvođač: "></asp:Label>
&emsp; &emsp; &emsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Naziv albuma: "></asp:Label>
&nbsp; &emsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Žanr: "></asp:Label>
&nbsp; &emsp; &emsp;  &emsp; &emsp; &emsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Godina izdanja: "></asp:Label>
&nbsp; &emsp;
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Izdavačka kuća: "></asp:Label>
&nbsp; &emsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Trazi" />
    &nbsp;&nbsp; &emsp; &emsp;
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="izvodjac" HeaderText="Izvodjac" />
            <asp:BoundField DataField="naziv" HeaderText="Naziv albuma" />
            <asp:BoundField DataField="zanr" HeaderText="Zanr" />
            <asp:BoundField DataField="godina" HeaderText="Godina izdavanja" />
            <asp:BoundField DataField="izdavac" HeaderText="Izdavacka kuca" />
            <asp:ImageField DataImageUrlField="slika" HeaderText="Slika omota">
                <ControlStyle Height="50px" Width="50px" />
            </asp:ImageField>
        </Columns>
    </asp:GridView>
    <br />
&nbsp;<br />
</asp:Content>
