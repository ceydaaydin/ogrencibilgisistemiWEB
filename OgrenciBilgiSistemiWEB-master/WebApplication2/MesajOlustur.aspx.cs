using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace WebApplication2
{
    public partial class MesajOluştur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtGonderen.Text = "0002";
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
           

        }
    }
}