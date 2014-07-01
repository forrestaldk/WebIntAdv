using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    // Sten  = 1
    // Saks  = 2
    // Papir = 3
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    #region knapper
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
    protected void ButtonSpilIgen_Click(object sender, EventArgs e)
    {
        PanelVælg.Visible = true;
        PanelResultat.Visible = false;
    }

    #endregion
    #region Metode 1 - Spil
    // Input:   Spillerens valg som integer
    // Arbejde: Styrer spillets forløb: Vælger for computeren, finder vinderen, viser resultatet
    // Output:  Intet
    private void Spil(int SpillerValg)
    {
        int ComputerValg = VælgForComputer();
        string Vinder = FindVinder(SpillerValg, ComputerValg);
        VisResultat(SpillerValg, ComputerValg, Vinder);
    }
    #endregion
    #region Metode 2 - Vis resultat
    // Input:   Spillerens valg og computerens valg som integers. Vinderens navn som string
    // Arbejde: Skjuler panelet med valgmulighederne og viser resultatet af spillet
    // Output:  intet
    private void VisResultat(int SpillerValg, int ComputerValg, string Vinder)
    {
        PanelVælg.Visible = false;
        PanelResultat.Visible = true;
        ImageSpillerValg.ImageUrl = "~/images/" + navn(SpillerValg) + ".png";
        ImageComputerValg.ImageUrl = "~/images/" + navn(ComputerValg) + ".png";
        LabelResultat.Text = Vinder + " vandt!";
    }
    #endregion  
    #region Metode 3 - VælgForComputer
    // Input:   Intet
    // Arbejde: Vælger et tilfældig tal 1, 2 eller 3
    // Output:  det tilfældige tal
    private int VælgForComputer()
    {
        Random Randomizer = new Random();
        return Randomizer.Next(1, 4);
    }
    #endregion
    #region Metode 4 - FindVinder
  
    // Input:   Spilleres og computerens valg som integers
    // Arbejde: Finder vinderen efter almindelig s,s,p regler
    // Output:  Spillerens navn som string, eller "Ingen" i tilfælde af uafgjort
    private string FindVinder(int SpillerValg, int ComputerValg)
    {
        if (SpillerValg == ComputerValg)
        {
            return "Ingen";
        }
            //|| = eller // 
        else if ((SpillerValg == 1 && ComputerValg == 2) ||(SpillerValg == 2 && ComputerValg == 3) || (SpillerValg == 3 && ComputerValg == 1))
        {
            return "Du";
        }
        else
        {
            return "Computeren";
        }
    } 
    #endregion
    #region Metode 5 - Navn
    // Input:   Et valg af symbol som integer: 1, 2 eller 3
    // Arbejde: Oversætter valget fra integer til string
    // Output:  Det valgte symbol som string
    private string navn(int Valg)
    {
        switch (Valg)
        {
            case 1:  return "sten";
            case 2:  return "saks";
            default: return "papir";
        }
    }
    #endregion
}