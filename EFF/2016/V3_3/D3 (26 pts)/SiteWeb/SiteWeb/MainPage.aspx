<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="SiteWeb.MainPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblnum" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="lblnom" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="lblnb_uv" runat="server" Text="Label"></asp:Label><br />
        <br />
        <br />
        <asp:GridView ID="gv1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
