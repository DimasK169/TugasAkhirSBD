using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugasakhir2.Classes;
using System.Drawing;

namespace Tugasakhir2.bootstrap
{
    public partial class Tumbuhan : System.Web.UI.Page
    {
        SqlConnection T_SqlConn = new SqlConnection(ClsModule.Conn.ToString());
        SqlCommand T_cmd = new SqlCommand();
        SqlDataAdapter T_sda = new SqlDataAdapter();
        DataTable T_dt = new DataTable();
        DataSet T_ds = new DataSet();


        protected void Page_Load(object sender, EventArgs e)
        {
            T_SqlConn.Open();
            if (!Page.IsPostBack)
            {
                T_DataShow();
            }
        }

        public void T_DataShow()
        {
            T_ds = new DataSet();
            T_cmd.CommandText = "Select tumbuhan_id, nama_latin, nama_umum, klasifikasi_id, kegunaan_id from Tumbuhan where (IsDeleted = 0)";
            T_cmd.Connection = T_SqlConn;
            T_sda = new SqlDataAdapter(T_cmd);
            T_sda.Fill(T_ds);
            T_cmd.ExecuteNonQuery();
            T_GridView.DataSource = T_ds;
            T_GridView.DataBind();
            T_SqlConn.Close();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            T_dt = new DataTable();
            T_cmd.CommandText = "Insert Into tumbuhan(tumbuhan_id ,nama_latin, nama_umum, klasifikasi_id, kegunaan_id) values ('" + TxtTumbuhanID.Text + "','" + TxtNamaLatin.Text + "', '" + TxtNamaUmum.Text + "', '" + TxtKlasifikasiID.Text + "','" + TxtKegunaanID.Text  + "')";
            T_cmd.Connection = T_SqlConn;
            T_cmd.ExecuteNonQuery();
            T_DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            T_dt = new DataTable();
            T_cmd.CommandText = "Update tumbuhan set isDeleted = '1' where tumbuhan_id='" + TxtTumbuhanID.Text + "'";
            T_cmd.Connection = T_SqlConn; 
            T_cmd.ExecuteNonQuery(); 
            T_DataShow();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            T_dt = new DataTable();
            T_cmd.CommandText = "Update tumbuhan set nama_latin='" + TxtNamaLatin.Text.ToString() + "',  nama_umum = '" + TxtNamaUmum.Text.ToString() + "', klasifikasi_id = '" + TxtKlasifikasiID.Text + "', kegunaan_id = '" + TxtKegunaanID.Text + "' WHERE tumbuhan_id = '" + TxtTumbuhanID.Text + "'";
            T_cmd.Connection = T_SqlConn; 
            T_cmd.ExecuteNonQuery(); 
            T_DataShow();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TxtTumbuhanID.Text= null;
            TxtNamaLatin.Text = null;
            TxtNamaUmum.Text = null;   
            TxtKlasifikasiID.Text= null;
            TxtKegunaanID.Text= null;
        }
    }
}