<%@ Page Title="Page d'accueil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SiteWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>:E-Mail<br />
    <asp:TextBox ID="tbpasswd" runat="server"></asp:TextBox>:Password<br />
    <p style="margin: 0px 0px 0px 40px;">
        <asp:Button ID="btnsignin" runat="server" Text="Signin" 
            onclick="btnsignin_Click" /><br />
        <asp:CheckBox ID="chboxguest" runat="server" Text="Guest" /><br />
        <asp:Label ID="lblerr" runat="server" Text="" style="color:Red;"></asp:Label>
    </p>
    <br />
</asp:Content>
