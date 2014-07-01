using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UdvidetAntal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // Knapper til antal spil
    protected void ButtonAntal1_Click(object sender, EventArgs e)
    {
        StartSpil(1);
    }
    protected void ButtonAntal3_Click(object sender, EventArgs e)
    {
        StartSpil(3);
    }
    protected void ButtonAntal5_Click(object sender, EventArgs e)
    {
        StartSpil(5);
    }

    // Input:   Antal valgte spil som integer
    // Arbejde: Tilføjer valgte til session og starter spillet
    // Output:  Intet
    private void StartSpil(int Antal)
    {
        Session["AntalSpilTilbage"] = Antal;
        Session["SpillerPoint"] = 0;
        Session["ComputerPoint"] = 0;

        Response.Redirect("Udvidet.aspx");
    }
}