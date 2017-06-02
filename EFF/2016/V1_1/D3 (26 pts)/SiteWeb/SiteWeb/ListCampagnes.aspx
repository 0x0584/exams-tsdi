<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCampagnes.aspx.cs" Inherits="SiteWeb.ListCampagnes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlist" runat="server" >
        </asp:DropDownList>
    
        <asp:Button ID="btnrefresh" runat="server" Text="Refresh" 
            onclick="btnrefresh_Click" />
    
    </div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
