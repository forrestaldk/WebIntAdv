<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UdvidetAntal.aspx.cs" Inherits="UdvidetAntal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sten saks papir - Udvidet</h1>

            <asp:Panel ID="PanelSpilType" runat="server">
                <h3>Velkommen - vælg hvor mange omgange du vil spille</h3>
                <asp:Button ID="ButtonAntal1" runat="server" Text="1" OnClick="ButtonAntal1_Click" />
                <asp:Button ID="ButtonAntal3" runat="server" Text="Bedst af 3" OnClick="ButtonAntal3_Click" />
                <asp:Button ID="ButtonAntal5" runat="server" Text="Bedst af 5" OnClick="ButtonAntal5_Click" />
            </asp:Panel>
            <a href="Default.aspx">Prøv også den simple version</a>
        </div>
    </form>
</body>
</html>
