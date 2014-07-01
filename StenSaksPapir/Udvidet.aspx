<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Udvidet.aspx.cs" Inherits="Udvidet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Udvidet</title>
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
            <h1>Sten saks papir - Udvidet</h1>

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
                </div>
                <div class="valg">
                    <h3>Computeren valgte:</h3>
                    <asp:Image ID="ImageComputerValg" runat="server" />
                </div>
                <h2 class="clear">
                    <asp:Label ID="LabelResultat" runat="server"></asp:Label>
                </h2>
                <h2>Stilling:</h2>
                <table>
                    <tr>
                        <td>Spiller point:</td>
                        <td><asp:Label ID="LabelSpillerPoint" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Computer point:</td>
                        <td><asp:Label ID="LabelComputerPoint" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Antal runder tilbage:</td>
                        <td><asp:Label ID="LabelAntalRunderTilbage" runat="server" Text=""></asp:Label></td>
                    </tr>
                </table>
                <h2><asp:Label ID="LabelSpilletErSlut" runat="server" Text=""></asp:Label></h2>
                <asp:Button ID="ButtonSpilIgen" runat="server" Text="Spil igen" OnClick="ButtonSpilIgen_Click" Visible="false"/>
            </asp:Panel>

            <asp:LinkButton ID="LinkButtonSimpel" runat="server" OnClick="LinkButtonSimpel_Click">Prøv også den simple version</asp:LinkButton>


        </div>
    </form>
</body>
</html>
