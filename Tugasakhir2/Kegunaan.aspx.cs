using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugasakhir2.Classes;

namespace Tugasakhir2.Tabel
{
    public partial class Kegunaan : System.Web.UI.Page
    {
        SqlConnection Ke_SqlConn = new SqlConnection(ClsModule.Conn.ToString());
        SqlCommand Ke_cmd = new SqlCommand();
        SqlDataAdapter Ke_sda = new SqlDataAdapter();
        DataTable Ke_dt = new DataTable();
        DataSet Ke_ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            Ke_SqlConn.Open();
            if (!Page.IsPostBack)
            {
                Ke_DataShow();
            }
        }

        public void Ke_DataShow()
        {
            Ke_ds = new DataSet();
            Ke_cmd.CommandText = "Select kegunaan_id, kegunaan from kegunaan where (IsDeleted = 0)";
            Ke_cmd.Connection = Ke_SqlConn;
            Ke_sda = new SqlDataAdapter(Ke_cmd);
            Ke_sda.Fill(Ke_ds);
            Ke_cmd.ExecuteNonQuery();
            Ke_GridView.DataSource = Ke_ds;
            Ke_GridView.DataBind();
            Ke_SqlConn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Ke_dt = new DataTable();
            Ke_cmd.CommandText = "Insert Into kegunaan(kegunaan_id , kegunaan) values ('" + TxtKegunaanID.Text + "','" + TxtKegunaan.Text + "')";
            Ke_cmd.Connection = Ke_SqlConn;
            Ke_cmd.ExecuteNonQuery();
            Ke_DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Ke_dt = new DataTable();
            Ke_cmd.CommandText = "Update kegunaan set isDeleted = '1' where kegunaan_id = '" + TxtKegunaanID.Text + "'";
            Ke_cmd.Connection = Ke_SqlConn;
            Ke_cmd.ExecuteNonQuery();
            Ke_DataShow();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Ke_dt = new DataTable();
            Ke_cmd.CommandText = "Update kegunaan set kegunaan='" + TxtKegunaan.Text.ToString() + "' WHERE kegunaan_id = '" + TxtKegunaanID.Text + "'";
            Ke_cmd.Connection = Ke_SqlConn;
            Ke_cmd.ExecuteNonQuery();
            Ke_DataShow();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TxtKegunaan.Text = null;
            TxtKegunaanID.Text = null;
        }
    }
}