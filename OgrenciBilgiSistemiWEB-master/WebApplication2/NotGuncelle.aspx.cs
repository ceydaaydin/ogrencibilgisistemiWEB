using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace WebApplication2
{
    public partial class NotGuncelle : System.Web.UI.Page
    {
        int nid;
        protected void Page_Load(object sender, EventArgs e)
        {
 
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
  
        }
    }
}