using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotGuncelle : System.Web.UI.Page
    {
        int nid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());
                DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();
                TxtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].OGRENCIADSOYAD;
                TxtDersAd.Text = dt.NotGetir2(nid)[0].DERSAD;
                TxtOgrDurum.Text = dt.NotGetir2(nid)[0].DURUM.ToString();
                TxtOgrSınav1.Text = dt.NotGetir2(nid)[0].SINAV1.ToString();
                TxtOgrSınav2.Text = dt.NotGetir2(nid)[0].SINAV2.ToString();
                TxtOgrSınav3.Text = dt.NotGetir2(nid)[0].SINAV3.ToString();
                TxtOgrOrt.Text = dt.NotGetir2(nid)[0].ORTALAMA.ToString();
                TxtOgrid.Text = dt.NotGetir2(nid)[0].OGRENCIID.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3;
            double ort;
            sinav1 = Convert.ToInt32(TxtOgrSınav1.Text);
            sinav2 = Convert.ToInt32(TxtOgrSınav2.Text);
            sinav3 = Convert.ToInt32(TxtOgrSınav3.Text);

            ort = (sinav1 + sinav2 + sinav3) / 3;
            TxtOgrOrt.Text = ort.ToString("0.00");
            if (ort <= 50)
            {

                TxtOgrDurum.Text = "False";
            }
            else if (ort >= 50)
            {
                TxtOgrDurum.Text = "True";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();
            dt.NotGuncelle(byte.Parse(TxtOgrSınav1.Text), byte.Parse(TxtOgrSınav2.Text), byte.Parse(TxtOgrSınav3.Text), decimal.Parse(TxtOgrOrt.Text), bool.Parse(TxtOgrDurum.Text), nid);
            Response.Redirect("NotListesi.aspx");
        }
    }
}