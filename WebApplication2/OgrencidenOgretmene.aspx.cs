using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrencidenOgretmene : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TxtGonderen.Text = Session["NUMARA"].ToString();
            if (Page.IsPostBack == false)
            {


                DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
                DropDownList1.DataSource = dt.OgretmenListesi();
                DropDownList1.DataTextField = "OGRTADSOYAD";
                DropDownList1.DataValueField = "OGRTID";
                DropDownList1.DataBind();
            }
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();
            dt.MesajGonder(TxtGonderen.Text, DropDownList1.Text,TxtBaslik.Text,TxtMesajicerik.Value);
            Response.Redirect("OgrenciGiden.aspx");
        }
    }
}