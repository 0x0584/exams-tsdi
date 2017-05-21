<%@ Page Title="Qui sommes-nous" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="pEtat.aspx.cs" Inherits="efm_v1.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <a href="pEvent.aspx?event=encours" >En Cours</a> <br />
    <a href="pEvent.aspx?event=enattente" >En Attente</a> <br />
    <a href="pEvent.aspx?event=termine" >Termine</a> <br />
    <br />

    <asp:HyperLink NavigateUrl="~/pEvent.aspx?event=encours" ID="lnkenc" runat="server">en cours</asp:HyperLink> <br />
    <asp:HyperLink NavigateUrl="~/pEvent.aspx?event=enattente" ID="lnkenatt" runat="server">en attente</asp:HyperLink> <br />
    <asp:HyperLink NavigateUrl="~/pEvent.aspx?event=termine" ID="lnkterm" runat="server">termine</asp:HyperLink> <br />
    <br />

</asp:Content>
