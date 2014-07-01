<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simpel</title>
    <style>
        .valg {
            float: left;
        }
        .clear {
            clear: both;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sten saks papir</h1>

            <asp:Panel ID="PanelVælg" runat="server">
                <h3>Vælg:</h3>
                <asp:ImageButton ID="ImageButtonSten" runat="server" ImageUrl="~/images/sten.png" OnClick="ImageButtonSten_Click" />
                <asp:ImageButton ID="ImageButtonSaks" runat="server" ImageUrl="~/images/saks.png" OnClick="ImageButtonSaks_Click" />
                <asp:ImageButton ID="ImageButtonPapir" runat="server" ImageUrl="~/images/papir.png" OnClick="ImageButtonPapir_Click" />
            </asp:Panel>

            <asp:Panel ID="PanelResultat" runat="server" Visible="false">
                <div class="valg">
                    <h3>Du valgte:</h3>
                    <asp:Image ID="ImageSpillerValg" runat="server" />
                    <asp:Label ID="LabelSpillerValg" runat="server"></asp:Label>
                </div>
                <div class="valg">
                    <h3>Computeren valgte:</h3>
                    <asp:Image ID="ImageComputerValg" runat="server" />
                    <asp:Label ID="LabelComputerValg" runat="server"></asp:Label>
                </div>
                <h2 class="clear">
                    <asp:Label ID="LabelResultat" runat="server"></asp:Label>
                </h2>
                <asp:Button ID="ButtonSpilIgen" runat="server" Text="Spil igen" OnClick="ButtonSpilIgen_Click" />
            </asp:Panel>

            <a href="UdvidetAntal.aspx">Prøv også den udvidede version</a>
        </div>
    </form>
</body>
</html>
