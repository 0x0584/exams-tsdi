<%@ Page Title="Page d'accueil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="efm_v1._Default" %>
    
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <p>
        <asp:Label ID="lblevent" runat="server" Text="idevent"></asp:Label>
        <asp:TextBox ID="tbeventid" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="tbeventid" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />        
        <asp:Label ID="lblnomevent" runat="server" Text="nom event"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="date" runat="server" Text="date even"></asp:Label>
        t<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label4" runat="server" Text="etat event"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="rdetatevent" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RadioButtonList ID="rdetatevent" runat="server">
            <asp:ListItem>en cours</asp:ListItem>
            <asp:ListItem>en attente</asp:ListItem>
            <asp:ListItem>termine</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="id stag"></asp:Label>
        <asp:DropDownList ID="ddl_ids" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="ddl_ids" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </p>
    <p >
        <asp:Button ID="Button1" runat="server" Text="Add" 
            style="margin: 5px 10px 5px 30px" onclick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Cancel" style="margin: 5px 30px 5px 10px"/>
    </p>

</asp:Content>
