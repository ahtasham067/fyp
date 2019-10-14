using FYP.Models;
using FYP.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            

            return View();
        }
        public ActionResult AddLoginDetail()
        {
            return View();
        }
        public ActionResult DomainandAlliedFields()
        {
            return View();
        }
        public ActionResult ExternalEvaluation()
        {
            return View();
        }
        public ActionResult InternalEvaluation()
        {
            return View();
        }
        public ActionResult MeetingForm()
        {
            return View();
        }
        public ActionResult ProposalEvaluationForm()
        {
            return View();
        }
        
            public ActionResult SDDEvaluationForm()
        {
            return View();
        }
        public ActionResult SRSEvaluationForm()
        {
            return View();
        }
        public ActionResult SRSEvaluationForm1()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);


            string sqlquery1 = "SELECT CoSupervisorName FROM [dbo].[Co_Supervisor]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
            sqlconn.Open();
            var reader = sqlcomm.ExecuteReader();

            List<Supervisor> records = new List<Supervisor>();
            while (reader.Read())
            {
                var record = new Supervisor();
                var docid = Convert.ToInt32(reader["Model1"]);
                record.SupervisorName = reader["SupervisorName"].ToString();

                records.Add(record);
            }
            sqlconn.Close();
            return View();

        }
        [HttpGet]
        public ActionResult Students()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String sql = "SELECT CoSupervisorName FROM [dbo].[Co_Supervisor]";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);

            var model = new List<Supervisor>();
            using (SqlConnection conn = new SqlConnection(mainconn))
            {
                sqlconn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var student = new Supervisor();
                    student.SupervisorName = rdr["SupervisorName"].ToString();
            model.Add(student);
                }
                sqlconn.Close();

            }

            return View(model);
        }
        public ActionResult Student()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SupervisorandCosupervisor()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SupervisorandCosupervisor(SupervisorandCosupervisorVM obj)
        { if (obj.SupervisorName!=null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery1 = "insert into [dbo].[Supervisor] (SupervisorName) values (@name)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                sqlconn.Open();
                sqlcomm.Parameters.AddWithValue("@name", obj.SupervisorName);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }
            else
            {
                if(obj.CoSupervisorName!=null)
                {
                    string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery1 = "insert into [dbo].[Co_Supervisor] (CoSupervisorName) values (@name)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@name", obj.CoSupervisorName);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                }
            }
            

            
            return View("SupervisorandCosupervisor");
        }

        public ActionResult SupervisorEvaluation()
        {
            return View();
        }
        public ActionResult TeacherIndex()
        {
            return View();
        }
        public ActionResult UpdateEvaluationMarks()
        {
            return View();
        }

    }
}