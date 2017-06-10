<%@ Page Title="Page d'accueil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SiteWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:TextBox ID="tbnumf" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbnumf"
        ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
    Nom Formation<br />
    <asp:TextBox ID="tbpassf" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ControlToValidate="tbpassf"
        ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
    Password<br />
    <asp:Button ID="btnsignin" runat="server" Text="Sign-in" 
        onclick="btnsignin_Click" />
    <asp:Label ID="lblerr" runat="server" Text="Label"></asp:Label>
</asp:Content>
