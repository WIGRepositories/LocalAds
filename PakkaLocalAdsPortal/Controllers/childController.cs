using PakkaLocalAdsPortal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PakkaLocalAdsPortal.Controllers
{
    public class childController : ApiController
    {
        

            [HttpGet]
        public DataTable GetChildImagePreview(int x, int y)
        {
            DataTable Tbl = new DataTable();
            try
            {

                //connect to database
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["btposdb"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetChildImagePreview";

                cmd.Connection = conn;
                DataSet ds = new DataSet();

                cmd.Parameters.Add("@x", SqlDbType.Int).Value = x;
                cmd.Parameters.Add("@y", SqlDbType.Int).Value = y;
                
                SqlDataAdapter db = new SqlDataAdapter(cmd);
                db.Fill(ds);
                Tbl = ds.Tables[0];
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Tbl;
        }
    }
}
