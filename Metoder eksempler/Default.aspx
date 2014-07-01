<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        .yellow {
            background-color: rgb(53, 92, 98);
            color: #fff;
        }

        section {
            background-color: rgb(59, 200, 166);
            margin-bottom: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <header class="row">

            <h1>Øvelser til Metoder i C#.NET</h1>
            <p class="lead">
                
            </p>

            <asp:Button runat="server" ID="Button_visAlleopgaver" OnClick="Button_visAlleopgaver_Click" Text="Vis alle opgaver" />
        </header>
        <article>
            <asp:Panel runat="server" ID="Panel_ovelse1_7">
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 1 - Hej Verden</legend>
                    <h3 class="yellow">
                        <asp:Label ID="Label_ovelse1" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 2 - Hej [Bent]</legend>
                    <h3 class="yellow">
                        <asp:Label ID="Label_ovelse2" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 3 - Hej [Bent] og [Lis]</legend>
                    <h3 class="yellow">
                        <asp:Label ID="Label_ovelse3" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 4 - Hej eks-ven</legend>
                    <h3 class="yellow">
                        <asp:Label ID="Label_ovelse4" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 4a - Hej [eks-ven] med TextBox</legend>
                    <h3 class="yellow">
                        <asp:TextBox ID="TextBox_ovelse4a" runat="server" ></asp:TextBox>
                        <asp:Button ID="Button_ovelse4a" runat="server" Text="Button" OnClick="Button_ovelse4a_Click" CssClass="btn btn-success btn-sm" />
                        <asp:Label ID="Label_ovelse4a" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 5 - Hej [ven] returneres</legend>
                    <h3 class="yellow">
                        <asp:Label ID="Label_ovelse5" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 6 - Dobbelt op</legend>
                    <h3 class="yellow">
                        <asp:Label ID="Label_ovelse6" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 6a - Dobbelt op fra TextBox</legend>
                    <h3 class="yellow">
                        <asp:TextBox ID="TextBox_ovelse6a" runat="server" ></asp:TextBox>
                        <asp:Button ID="Button_ovelse6a" runat="server" Text="Button" CssClass="btn btn-success btn-sm" OnClick="Button_ovelse6a_Click" />
                        <asp:Label ID="Label_ovelse6a" runat="server" Text=""></asp:Label></h3>
                </fieldset>
            </section>
            <asp:Panel runat="server" ID="Panel_Øvelse7">
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 7 - SELECT fra databasen</legend>
                    <h3 class="yellow">
                        <table class="nav-justified" style="width:50%"; >
                            <asp:Repeater ID="Repeater_ovelse7" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("br_id") %> I </td>
                                        <td><%# Eval("br_brugernavn") %></td>
                                        <td><%# Eval("br_adgangskode") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </table>

                
                </fieldset>
            </section>
                </asp:Panel>
                </asp:Panel>
            <asp:Panel runat="server" ID="Panel_øvelse7a">
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 7a - SELECT fra databasen
                        <asp:Button ID="Button7a" runat="server" OnClick="Button7a_Click" Text="Vis top X" />
                    </legend>
                    <h3 class="yellow">
                        <table class="nav-justified" style="width:50%"; >
                            <asp:Repeater ID="Repeater7a" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("br_id") %> I </td>
                                        <td><%# Eval("br_brugernavn") %></td>
                                        <td><%# Eval("br_adgangskode") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                            
                        </table>
>
                
                </fieldset>
            </section>
                </asp:Panel>
                   <asp:Panel runat="server" ID="Panel_Ovelse7b">
            <section class="row">
                <fieldset class="col-md4">
                    <legend>Øvelse 7b - SELECT fra databasen med dropdown og Autopostback
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="1">Top 1</asp:ListItem>
                            <asp:ListItem Value="2">Top 2</asp:ListItem>
                            <asp:ListItem Value="3">Top 3</asp:ListItem>
                            <asp:ListItem Value="4">Top 4</asp:ListItem>
                            <asp:ListItem Value="5">Top 5</asp:ListItem>
                        </asp:DropDownList>
                    </legend>
                    <h3 class="yellow">
                        <table class="nav-justified" style="width:50%"; >
                            <asp:Repeater ID="Repeater_7B" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("br_id") %> I </td>
                                        <td><%# Eval("br_brugernavn") %></td>
                                        <td><%# Eval("br_adgangskode") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                            
                        </table>
                
                </fieldset>
            </section>
                </asp:Panel>
        </article>
    </form>
</body>
</html>
