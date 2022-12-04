using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugasakhir2.Classes;

namespace Tugasakhir2.bootstrap
{
    public partial class MainPage : System.Web.UI.Page
    {
        SqlConnection SqlConn = new SqlConnection(ClsModule.Conn.ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConn.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT dbo.tumbuhan.tumbuhan_id AS NO, dbo.tumbuhan.nama_latin AS [NAMA LATIN], dbo.tumbuhan.nama_umum AS [NAMA UMUM], dbo.klasifikasi.klasifikasi, dbo.kegunaan.kegunaan FROM dbo.tumbuhan INNER JOIN dbo.klasifikasi ON dbo.tumbuhan.klasifikasi_id = dbo.klasifikasi.klasifikasi_id INNER JOIN dbo.kegunaan ON dbo.tumbuhan.kegunaan_id = dbo.kegunaan.kegunaan_id Where (dbo.tumbuhan.IsDeleted =0)";
            cmd.Connection = SqlConn;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView.DataSource = ds;
            GridView.DataBind();
        }

        protected void ButtonCari_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT dbo.tumbuhan.tumbuhan_id AS NO, dbo.tumbuhan.nama_latin AS [NAMA LATIN], dbo.tumbuhan.nama_umum AS [NAMA UMUM], dbo.klasifikasi.klasifikasi, dbo.kegunaan.kegunaan FROM dbo.tumbuhan INNER JOIN dbo.klasifikasi ON dbo.tumbuhan.klasifikasi_id = dbo.klasifikasi.klasifikasi_id INNER JOIN dbo.kegunaan ON dbo.tumbuhan.kegunaan_id = dbo.kegunaan.kegunaan_id Where (dbo.tumbuhan.IsDeleted =0) and dbo.tumbuhan.nama_umum = '" + TxtCari.Text + "'";
            cmd.Connection = SqlConn;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView.DataSource = ds;
            GridView.DataBind();
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            DataShow();
        }

        protected void BtnRecycle(object sender, EventArgs e)
        {

        }
    }
}