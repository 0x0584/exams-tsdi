<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="SiteWeb.Inscription" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <i>Signup as Participant</i>
        </p>
        <p>
            <asp:TextBox ID="tbname" runat="server"></asp:TextBox>
            Nom:
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="tbname" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="tbpren" runat="server"></asp:TextBox>
            Prenom:
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="tbpren" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>
            E-Mail:
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="RegularExpressionValidator" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ControlToValidate="tbemail" ></asp:RegularExpressionValidator>
            <br />
            <asp:TextBox ID="tbpasswd0" runat="server"></asp:TextBox>
            Password:
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="tbpasswd0" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="tbpasswd1" runat="server"></asp:TextBox>
            Repeat Password:
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="tbpasswd0"  ControlToValidate="tbpasswd1" ErrorMessage="CompareValidator"></asp:CompareValidator>
        </p>
        <p>
            <asp:Button ID="tbsignup" Text="Signup" runat="server" 
                Style="margin: 0px 0px 0px 40px;" onclick="tbsignup_Click" />
            <br />
        </p>
    </div>
    </form>
</body>
</html>
