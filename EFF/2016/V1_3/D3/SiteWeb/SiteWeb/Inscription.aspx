<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="SiteWeb.Inscription" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tbid" runat="server"></asp:TextBox>Id<asp:RequiredFieldValidator
            ID="rfvnom0" runat="server" ErrorMessage="ERR" ControlToValidate="tbid"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="tbname" runat="server"></asp:TextBox>Nom<asp:RequiredFieldValidator
            ID="rfvnom" runat="server" ErrorMessage="ERR" ControlToValidate="tbname" 
            ForeColor="#990000"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="tbpren" runat="server"></asp:TextBox>Prenom<asp:RequiredFieldValidator
            ID="rfvpren" runat="server" ErrorMessage="ERR" ControlToValidate="tbpren" 
            ForeColor="#990000"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>E-Mail<asp:RegularExpressionValidator
            ID="regvemail" runat="server" ValidationExpression="^([\w\.\-_]+)@([\w\-]+)(\.([\w]{2,3}))$"
            ErrorMessage="ERR" ControlToValidate="tbemail" ForeColor="#990000"></asp:RegularExpressionValidator>
        <br />
        <asp:TextBox ID="tbpasswd0" runat="server"></asp:TextBox>Password<asp:RequiredFieldValidator
            ID="rfvpasswd" runat="server" ErrorMessage="ERR" 
            ControlToValidate="tbpasswd0" ForeColor="#990000"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="tbpasswd1" runat="server"></asp:TextBox>Password<asp:CompareValidator
            ID="cvpasswd" runat="server" ErrorMessage="ERR" ControlToCompare="tbpasswd0"
            ControlToValidate="tbpasswd1" ForeColor="#990000"></asp:CompareValidator>
        <br />
        <asp:Button ID="btnsignin" runat="server" Style="margin-left: 120px;" Text="Sign-up"
            OnClick="btnsignin_Click" />
        <br />
    </div>
    <p>
        <asp:Label ID="lblerr" runat="server" Text="ERR"></asp:Label>
    </p>
    </form>
</body>
</html>
