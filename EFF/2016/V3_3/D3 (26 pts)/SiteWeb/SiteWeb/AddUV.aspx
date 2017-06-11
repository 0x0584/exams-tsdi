<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUV.aspx.cs" Inherits="SiteWeb.AddUV" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tbnumuv" runat="server" Width="30%"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbnumuv"
            ValidationExpression="[0-9]+" ErrorMessage="MUST BE A NUMBER"></asp:RegularExpressionValidator>
        :Num UV<br />
        <asp:TextBox ID="tbnom" runat="server" Width="30%"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="tbnom" ErrorMessage="*"></asp:RequiredFieldValidator>
        :Nom UV<br />
        <asp:TextBox ID="tbmass" runat="server" Width="30%"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="MUST >= 20" ControlToValidate="tbmass"
            ValueToCompare="20" Operator="GreaterThanEqual"></asp:CompareValidator>
        :mass Horaire<br />
        <asp:DropDownList ID="ddlist_ens" runat="server" Width="30%">
        </asp:DropDownList>
        :Formateur Ensigne
        <br />
        <asp:DropDownList ID="ddlist_res" runat="server" Width="30%">
        </asp:DropDownList>
        :Formateur Responsable
        <br />
        <br />
        <asp:Button ID="btnadd" runat="server" Text="Ajouter UV" 
            onclick="btnadd_Click" />
        <asp:Label ID="lblerr" runat="server" ForeColor="Maroon"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
