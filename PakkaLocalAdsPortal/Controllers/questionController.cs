using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PakkaLocalAdsPortal.Models;

namespace PakkaLocalAdsPortal.Controllers
{
    public class questionController : ApiController
    {
        public DataTable GetLocationquestion(int locationId)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["btposdb"].ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "GetLocationquestion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@locationId", SqlDbType.Int).Value = locationId;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    

        [HttpPost]

        //[Route("api/question/Savequestion")]
        public int Savequestion(questions q)
        {

             SqlConnection conn = new SqlConnection();

            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["btposdb"].ToString();



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "InsUpdDelquestion";
            cmd.CommandType = CommandType.StoredProcedure;



            SqlParameter f = new SqlParameter("@flag", SqlDbType.VarChar);
            f.Value =q. flag;
            cmd.Parameters.Add(f);

            SqlParameter p = new SqlParameter("@Id", SqlDbType.Int);
            p.Value = q.id;
            cmd.Parameters.Add(p);

            SqlParameter l = new SqlParameter("@locationId", SqlDbType.Int);
            l.Value = q.locationId;
            cmd.Parameters.Add(l);

            SqlParameter m = new SqlParameter("@question", SqlDbType.VarChar, 50);
            m.Value = q.question;
            cmd.Parameters.Add(m);

            SqlParameter t = new SqlParameter("@option1", SqlDbType.VarChar, 50);
            t.Value = q.option1;
            cmd.Parameters.Add(t);

            SqlParameter o = new SqlParameter("@option2", SqlDbType.VarChar, 50);
            o.Value = q.option2;
            cmd.Parameters.Add(o);

            SqlParameter op = new SqlParameter("@option3", SqlDbType.VarChar, 50);
            op.Value = q.option3;
            cmd.Parameters.Add(op);

            SqlParameter u = new SqlParameter("@option4", SqlDbType.VarChar, 50);
            u.Value = q.option4;
            cmd.Parameters.Add(u);



            SqlParameter c = new SqlParameter("@contestId", SqlDbType.VarChar, 50);
            c.Value = q.contestId;
            cmd.Parameters.Add(c);

            SqlParameter a = new SqlParameter("@answer", SqlDbType.VarChar, 50);
            a.Value = q.answer;
            cmd.Parameters.Add(a);


            SqlParameter fd = new SqlParameter("@FromDate", SqlDbType.Date);
            fd.Value = q.FromDate;
            cmd.Parameters.Add(fd);

            SqlParameter d = new SqlParameter("@ToDate", SqlDbType.Date);
            d.Value = q.ToDate;
            cmd.Parameters.Add(d);



           conn.Open();
            int status = cmd.ExecuteNonQuery();




            conn.Close();

            return status;
        }
    }
}