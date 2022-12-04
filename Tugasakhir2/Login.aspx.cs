using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Tugasakhir2.Classes;

namespace Tugasakhir2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable DtLogin = new DataTable();
            DtLogin = Clslogin.DtLogin(TxtUser.Text, TxtPassword.Text);

            
            if(DtLogin.Rows.Count != 0 ) 
            {
                Response.Redirect("MainPage.aspx");
            }
            else
            {
                LblWarining.Text = "Username atau Password salah";
            }

        }
    }
}