<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultation.aspx.cs" Inherits="SiteWeb.Consultation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
        Operation en cours
        </h1>
        <asp:DropDownList ID="ddlist" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnrefresh" runat="server" Text="Refresh" 
            onclick="btnrefresh_Click" />
        <br />
    <br />
        <asp:GridView ID="gv1" runat="server">
        </asp:GridView>
    
        <br />
        <asp:Label ID="lblemail" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
