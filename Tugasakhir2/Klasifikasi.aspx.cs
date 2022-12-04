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
    public partial class Klasifikasi : System.Web.UI.Page
    {
        SqlConnection Kl_SqlConn = new SqlConnection(ClsModule.Conn.ToString());
        SqlCommand Kl_cmd = new SqlCommand();
        SqlDataAdapter Kl_sda = new SqlDataAdapter();
        DataTable Kl_dt = new DataTable();
        DataSet Kl_ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            Kl_SqlConn.Open();
            if (!Page.IsPostBack)
            {
                Kl_DataShow();
            }
        }

        public void Kl_DataShow()
        {
            Kl_ds = new DataSet();
            Kl_cmd.CommandText = "Select * from Klasifikasi";
            Kl_cmd.Connection = Kl_SqlConn;
            Kl_sda = new SqlDataAdapter(Kl_cmd);
            Kl_sda.Fill(Kl_ds);
            Kl_cmd.ExecuteNonQuery();
            Kl_GridView.DataSource = Kl_ds;
            Kl_GridView.DataBind();
            Kl_SqlConn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Kl_dt = new DataTable();
            Kl_cmd.CommandText = "Insert Into klasifikasi(klasifikasi_id , klasifikasi) values ('" + TxtKlasifikasiID.Text + "','" + TxtKlasifikasi.Text + "')";
            Kl_cmd.Connection = Kl_SqlConn;
            Kl_cmd.ExecuteNonQuery();
            Kl_DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Kl_dt = new DataTable();
            Kl_cmd.CommandText = "Delete from klasifikasi where klasifikasi_id='" + TxtKlasifikasiID.Text + "'";
            Kl_cmd.Connection = Kl_SqlConn;
            Kl_cmd.ExecuteNonQuery();
            Kl_DataShow();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Kl_dt = new DataTable();
            Kl_cmd.CommandText = "Update klasifikasi set klasifikasi='" + TxtKlasifikasi.Text.ToString() + "' WHERE klasifikasi_id = '" + TxtKlasifikasiID.Text + "'";
            Kl_cmd.Connection = Kl_SqlConn;
            Kl_cmd.ExecuteNonQuery();
            Kl_DataShow();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TxtKlasifikasi.Text = null;
            TxtKlasifikasiID.Text = null;
        }
    }
}