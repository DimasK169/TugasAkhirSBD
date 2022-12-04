using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugasakhir2.Classes;

namespace Tugasakhir2
{
    public partial class RecycleTanaman : System.Web.UI.Page
    {
        SqlConnection TD_SqlConn = new SqlConnection(ClsModule.Conn.ToString());
        SqlCommand TD_cmd = new SqlCommand();
        SqlDataAdapter TD_sda = new SqlDataAdapter();
        DataTable TD_dt = new DataTable();
        DataSet TD_ds = new DataSet();

        SqlConnection TKe_SqlConn = new SqlConnection(ClsModule.Conn.ToString());
        SqlCommand TKe_cmd = new SqlCommand();
        SqlDataAdapter TKe_sda = new SqlDataAdapter();
        DataTable TKe_dt = new DataTable();
        DataSet TKe_ds = new DataSet();


        protected void Page_Load(object sender, EventArgs e)
        {
            TD_SqlConn.Open();
            TKe_SqlConn.Open();
            if (!Page.IsPostBack)
            {
                TD_DataShow();
                TKe_DataShow();
            }
        }

        public void TD_DataShow()
        {
            TD_ds = new DataSet();
            TD_cmd.CommandText = "Select tumbuhan_id, nama_latin, nama_umum, klasifikasi_id, kegunaan_id from Tumbuhan where (IsDeleted = 1)";
            TD_cmd.Connection = TD_SqlConn;
            TD_sda = new SqlDataAdapter(TD_cmd);
            TD_sda.Fill(TD_ds);
            TD_cmd.ExecuteNonQuery();
            GridViewDeleted.DataSource = TD_ds;
            GridViewDeleted.DataBind();
            TD_SqlConn.Close();
        }

        public void TKe_DataShow()
        {
            TKe_ds = new DataSet();
            TKe_cmd.CommandText = "Select kegunaan_id, kegunaan from kegunaan where (IsDeleted = 1)";
            TKe_cmd.Connection = TKe_SqlConn;
            TKe_sda = new SqlDataAdapter(TKe_cmd);
            TKe_sda.Fill(TKe_ds);
            TKe_cmd.ExecuteNonQuery();
            GridViewDeletedKegunaan.DataSource = TKe_ds;
            GridViewDeletedKegunaan.DataBind();
            TKe_SqlConn.Close();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            TD_dt = new DataTable();
            TD_cmd.CommandText = "Delete from tumbuhan where tumbuhan_id='" + TxtIdDeletedTumbuhan.Text + "'";
            TD_cmd.Connection = TD_SqlConn;
            TD_cmd.ExecuteNonQuery();
            TD_DataShow();
        }

        protected void ButtonRestore_Click(object sender, EventArgs e)
        {
            TD_dt = new DataTable();
            TD_cmd.CommandText = "Update tumbuhan set isDeleted = '0' where tumbuhan_id='" + TxtIdDeletedTumbuhan.Text + "'";
            TD_cmd.Connection = TD_SqlConn;
            TD_cmd.ExecuteNonQuery();
            TD_DataShow();
        }

        protected void ButtonRestoreKegunaan_Click(object sender, EventArgs e)
        {
            TKe_dt = new DataTable();
            TKe_cmd.CommandText = "Update kegunaan set isDeleted = '0' where kegunaan_id='" + TxtIdDeletedKegunaan.Text + "'";
            TKe_cmd.Connection = TKe_SqlConn;
            TKe_cmd.ExecuteNonQuery();
            TKe_DataShow();
        }

        protected void ButtonDeleteKegunaan_Click(object sender, EventArgs e)
        {
            TKe_dt = new DataTable();
            TKe_cmd.CommandText = "Delete from kegunaan where kegunaan_id='" + TxtIdDeletedKegunaan.Text + "'";
            TKe_cmd.Connection = TKe_SqlConn;
            TKe_cmd.ExecuteNonQuery();
            TKe_DataShow();
        }
    }
}