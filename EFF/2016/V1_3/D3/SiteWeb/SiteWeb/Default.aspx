<%@ Page Title="Page d'accueil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SiteWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>:E-Mail<br />
    <asp:TextBox ID="tbpasswd" runat="server"></asp:TextBox>:Password<br />
    <p style="margin: 0px 0px 0px 20px;">
        <asp:Button ID="btnsignin" runat="server" Text="Sign-in" 
            onclick="btnsignin_Click" />
        <asp:Button ID="btnsignup" runat="server" Text="Sign-up" 
            style="margin-left: 10px;" onclick="btnsignup_Click"/>
        <br />
        <asp:CheckBox ID="chboxguest" runat="server" Text="Guest" style="margin-left:45px;"/><br />
    </p>
        <asp:Label ID="lblerr" runat="server" Text="" style="color:Red;"></asp:Label>

    <br />
</asp:Content>
