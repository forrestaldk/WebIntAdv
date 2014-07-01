#region Using
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
#endregion

public partial class _Default : System.Web.UI.Page
{
    #region Page load events
    protected void Page_Load(object sender, EventArgs e)
    {
 
        Ovelse1();
        Ovelse2("Bent");
        Ovelse3("Bent", "Lis");
        Ovelse4("");
        Label_ovelse5.Text = Ovelse5("jens");
        Ovelse6(21);
        Repeater_ovelse7.DataSource = Ovelse7("SELECT * FROM webIII_BRS_brugere");
        Repeater_ovelse7.DataBind();
        Panel_Øvelse7.Visible = true;
        
        
    }
    #endregion
    #region Click Events
        #region Øvelse4a
        protected void Button_ovelse4a_Click(object sender, EventArgs e)
        {
            Ovelse4a(TextBox_ovelse4a.Text);
        } 
        #endregion
        #region Øvelse 6a
        protected void Button_ovelse6a_Click(object sender, EventArgs e)
        {
            Ovelse6a(Convert.ToInt32(TextBox_ovelse6a.Text));
        } 
        #endregion
        #region Øvelse 7a
        public void Button7a_Click(object sender, EventArgs e)
        {
            int topX = 2;
            Panel_ovelse1_7.Visible= false;
            Panel_øvelse7a.Visible = true;
            Repeater7a.DataSource = Ovelse7("SELECT top " + topX + "* FROM webIII_BRS_brugere");
            Repeater7a.DataBind();
        } 
        #endregion
    #endregion
    #region Øvelser
        #region Øvelse1
    private void Ovelse1()
    {
        Label_ovelse1.Text = "Hej verden";
    } 
    #endregion
        #region Øvelse 2
    private void Ovelse2(string navn)
    {
        Label_ovelse2.Text = "Hej " + navn;
    } 
    #endregion
        #region Øvelse 3
        private void Ovelse3(string navn, string navn2)
        {
            Label_ovelse3.Text = "Hej " + navn + " og " + navn2;
        } 
        #endregion
        #region Øvelse 4
        private void Ovelse4(string navn)
        {
            if (navn == "")
            {
                Label_ovelse4.Text = "Hej Eks-ven";
            }
            else
            {
                Label_ovelse4.Text = "Hej " + navn + " bedste ven i hele verden";
            }

        } 
        #endregion
        #region Øvelse 4a
        private void Ovelse4a(string navn)
        {
            if (navn == "")
            {
                Label_ovelse4a.Text = "Hej Eks-ven";
            }
            else
            {
                Label_ovelse4a.Text = "Hej " + navn;
            }
        } 


        #endregion
        #region Øvelse 5
        private string Ovelse5(string navn)
        {
            return "Hej " + navn + ", Du´ på!";
        }
    
        #endregion
        #region Øvelse 6
        private void Ovelse6(int tal)
        {
            Label_ovelse6.Text = (tal * 2).ToString();
        }
    
        #endregion
        #region Øvelse 6a
        private void Ovelse6a(int tal)
        {
            Label_ovelse6a.Text = (tal * 2).ToString();
        } 
        #endregion
        #region Øvelse 7
    private SqlCeDataReader Ovelse7(string sqlstreng)
    {
        SqlCeConnection conn = new SqlCeConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCeCommand cmd = new SqlCeCommand();
        cmd.Connection = conn;
        cmd.CommandText = sqlstreng;
        conn.Open();
        SqlCeDataReader reader = cmd.ExecuteReader();
        return reader;
        conn.Close();
    }
    
    #endregion
    #endregion
    #region Knapper
    protected void Button_visAlleopgaver_Click(object sender, EventArgs e)
    {
        Panel_ovelse1_7.Visible = true;
        Panel_Ovelse7b.Visible = true;
        Panel_Øvelse7.Visible = true;
        Panel_øvelse7a.Visible = true;

    } 
    #endregion
    #region DropDown
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            int topX = Convert.ToInt32(DropDownList1.SelectedValue);
            Panel_ovelse1_7.Visible = false;
            Panel_øvelse7a.Visible = false;
            Panel_Ovelse7b.Visible = true;
            Repeater_7B.DataSource = Ovelse7("SELECT top " + topX + "* FROM webIII_BRS_brugere");
            Repeater_7B.DataBind();
        }
        else
        {

        }
    } 
    #endregion
    
}