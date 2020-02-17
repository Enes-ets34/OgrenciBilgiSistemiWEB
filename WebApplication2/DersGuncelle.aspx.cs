using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DersGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            byte id;
            if (Page.IsPostBack == false)
            {
                id = Convert.ToByte(Request.QueryString["DERSID"].ToString());
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
                dt.DersSec(id);
                txtDersID.Text = id.ToString();
                txtDersAd.Text = dt.DersSec(id)[0].DERSAD;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
            dt.DersGuncelle(txtDersAd.Text, Convert.ToByte(txtDersID.Text));
            Response.Redirect("DersListesi.aspx");
        }
    }
}