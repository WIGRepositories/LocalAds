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
    public class ImageController : ApiController
    {      

               [HttpGet]
        public DataTable GetLocationImages(int locid)
        {
            DataTable Tbl = new DataTable();
            try
            {

                //connect to database
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["btposdb"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetLocationImages";

                cmd.Connection = conn;
                DataSet ds = new DataSet();

                cmd.Parameters.Add("@locid", SqlDbType.Int).Value = locid;
                
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
