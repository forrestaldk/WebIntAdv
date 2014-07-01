using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Udvidet : System.Web.UI.Page
{
    // Sten  = 1
    // Saks  = 2
    // Papir = 3

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    


    // Knapper til valg
    protected void ImageButtonSten_Click(object sender, ImageClickEventArgs e)
    {
        Spil(1);
    }
    protected void ImageButtonSaks_Click(object sender, ImageClickEventArgs e)
    {
        Spil(2);
    }
    protected void ImageButtonPapir_Click(object sender, ImageClickEventArgs e)
    {
        Spil(3);
    }
    // Spil igen knap
    protected void ButtonSpilNæsteRunde_Click(object sender, EventArgs e)
    {

    }


    // Input:   Spillerens valg som integer
    // Arbejde: Styrer spillets forløb: Vælger for computeren, finder vinderen, viser resultatet
    // Output:  Intet
    private void Spil(int SpillerValg)
    {
        int ComputerValg = VælgForComputer();
        string Vinder = FindVinder(SpillerValg, ComputerValg);
        VisResultat(SpillerValg, ComputerValg, Vinder);
        
        // Er spillet slut?
        if ((int)Session["AntalSpilTilbage"] == 0)
        {
            AfslutSpil();
        }
    }

    // Input:   Intet
    // Arbejde: Afslutter spillet ved at vise resultatet og slette session variable
    private void AfslutSpil()
    {
        string vinder;
        if ((int)Session["SpillerPoint"] > (int)Session["ComputerPoint"])
        {
            vinder = "Du";
        }
        else
        {
            vinder = "Computeren";
        }
        LabelSpilletErSlut.Text = "Spillet er slut. " + vinder + " vandt.";
        ButtonSpilIgen.Visible = true;
        Session.Abandon();
    }

    // Input:   Spillerens valg og computerens valg som integers. Vinderens navn som string
    // Arbejde: viser resultatet af spillet samt stillingen
    // Output:  intet
    private void VisResultat(int SpillerValg, int ComputerValg, string Vinder)
    {
        PanelResultat.Visible = true;
        ImageSpillerValg.ImageUrl = "~/images/" + navn(SpillerValg) + ".png";
        ImageComputerValg.ImageUrl = "~/images/" + navn(ComputerValg) + ".png";
        LabelResultat.Text = Vinder + " vandt denne omgang!";

        LabelSpillerPoint.Text = Session["SpillerPoint"].ToString();
        LabelComputerPoint.Text = Session["ComputerPoint"].ToString();
        LabelAntalRunderTilbage.Text = Session["AntalSpilTilbage"].ToString();
    }

    // Input:   Intet
    // Arbejde: Vælger et tilfældig tal 1, 2 eller 3
    // Output:  det tilfældige tal
    private int VælgForComputer()
    {
        Random Randomizer = new Random();
        return Randomizer.Next(1, 4);
    }

    // Input:   Spilleres og computerens valg som integers
    // Arbejde: Finder vinderen efter almindelig s,s,p regler. Tæller op og ned i Session variable 
    // Output:  Spillerens navn som string, eller "Ingen" i tilfælde af uafgjort
    private string FindVinder(int SpillerValg, int ComputerValg)
    {
        string vinder;
        if (SpillerValg == ComputerValg)
        {
            vinder = "Ingen";
        }
        else if ((SpillerValg == 1 && ComputerValg == 2) || (SpillerValg == 2 && ComputerValg == 3) || (SpillerValg == 3 && ComputerValg == 1))
        {
            Session["SpillerPoint"] = (int)Session["SpillerPoint"] + 1;
            Session["AntalSpilTilbage"] = (int)Session["AntalSpilTilbage"] - 1;
            vinder = "Du";
        }
        else
        {
            Session["ComputerPoint"] = (int)Session["ComputerPoint"] + 1;
            Session["AntalSpilTilbage"] = (int)Session["AntalSpilTilbage"] - 1;
            vinder = "Computeren";
        }
        return vinder;
    }

    // Input:   Et valg af symbol som integer: 1, 2 eller 3
    // Arbejde: Oversætter valget fra integer til string
    // Output:  Det valgte symbol som string
    private string navn(int Valg)
    {
        switch (Valg)
        {
            case 1: return "sten";
            case 2: return "saks";
            default: return "papir";
        }
    }

    protected void ButtonSpilIgen_Click(object sender, EventArgs e)
    {
        Response.Redirect("UdvidetAntal.aspx");
    }
    protected void LinkButtonSimpel_Click(object sender, EventArgs e)
    {
        // Hvis du forlader et igangværende spil slettes det
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}