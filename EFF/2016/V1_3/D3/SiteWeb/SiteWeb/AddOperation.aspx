<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOperation.aspx.cs" Inherits="SiteWeb.AddOperation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tbnomop" runat="server"></asp:TextBox>nomOp<br />
        <asp:TextBox ID="tbdescri" runat="server"></asp:TextBox>descri<br />
        <asp:TextBox ID="tbdateFin" runat="server"></asp:TextBox>dateFin<br />
        <asp:TextBox ID="tbmontantOp" runat="server"></asp:TextBox>montantOp<br />
        <asp:TextBox ID="tbnomBene" runat="server"></asp:TextBox>nomBene<br />
        <asp:TextBox ID="tbprenBene" runat="server"></asp:TextBox>prenBene<br />
        <asp:DropDownList ID="ddlistfamill" runat="server" Height="16px" Width="128px">
        </asp:DropDownList>
        idFamill
        <br />
        <asp:TextBox ID="tbcumul" runat="server"></asp:TextBox>cumulMontant<br />
        <asp:Button ID="btnadd" runat="server" Text="Ajouter" onclick="btnadd_Click" />
        <br />
    </div>
    </form>
</body>
</html>
