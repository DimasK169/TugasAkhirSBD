using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Tugasakhir2.Classes;


namespace Tugasakhir2.Classes
{
    public class Clslogin
    {
        public static DataTable DtLogin(string username, string password)
        {
            SqlConnection SqlConn = new SqlConnection(ClsModule.Conn.ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            SqlConn.Open();
            cmd.Connection= SqlConn;    
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from pengguna where username = '"+username+"' and password = '"+password+"'";
            da.SelectCommand= cmd;  
            da.Fill(dt);
            SqlConn.Close();
            return dt;
        }
    }
}