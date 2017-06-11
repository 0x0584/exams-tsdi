<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateUV.aspx.cs" Inherits="SiteWeb.UpdateUV" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="listUV" runat="server" Width="262px"></asp:ListBox>
        <asp:Button Style="margin:0px 0px 30px 10px;" ID="btncheck" runat="server" 
            Text="Select an UV" onclick="btncheck_Click" /><br />
        <asp:Button ID="btndel" runat="server" Text="Delete UV" OnClick="btndel_Click" />
        <asp:Button ID="btnupdate" runat="server" Text="Update UV" 
            onclick="btnupdate_Click" />
        <asp:Button ID="btnselected" runat="server" Text="Show Chapiters" 
            onclick="btnselected_Click" />
        <asp:Button ID="btnfilter" runat="server" Text="Filtering" />
    </div>
    <br />
    <div>
        <div id="radios" runat="server">

        </div>
        <asp:Label ID="lblinfo" runat="server" ForeColor="#00CC66"></asp:Label>
        <br />
        <asp:Label ID="lblerr" runat="server" ForeColor="Maroon"></asp:Label>
        <br />
    </div>
    <div>
        <asp:GridView ID="gv1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
