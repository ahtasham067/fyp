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
        private Model1 db = new Model1();
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
        [HttpGet]
        public ActionResult AddLoginDetail()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddLoginDetail(AddLoginDetailVM obj)
        {
            if (obj.BatchName != null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery1 = "insert into [dbo].[Batch] (BatchName) values (@name)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                sqlconn.Open();
                sqlcomm.Parameters.AddWithValue("@name", obj.BatchName);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }
            else
            {
                if (obj.ProgramName != null)
                {
                    string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery1 = "insert into [dbo].[Program] (ProgramName) values (@name)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@name", obj.ProgramName);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                }
               else
                {
                    if(obj.CampusName !=null)
                    {
                        string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                        SqlConnection sqlconn = new SqlConnection(mainconn);
                        string sqlquery1 = "insert into [dbo].[Campus] (CampusName) values (@name)";
                        SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                        sqlconn.Open();
                        sqlcomm.Parameters.AddWithValue("@name", obj.CampusName);
                        sqlcomm.ExecuteNonQuery();
                        sqlconn.Close();

                    }
                }
            }
            return View("AddLoginDetail");
        }
        [HttpGet]
        public ActionResult DomainandAlliedFields()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DomainandAlliedFields(DomainandAlliedFieldsVM obj)
        {
            if (obj.DomainName != null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery1 = "insert into [dbo].[Domain] (DomainName) values (@name)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                sqlconn.Open();
                sqlcomm.Parameters.AddWithValue("@name", obj.DomainName);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }
            else
            {
                if (obj.AlliedFieldName != null)
                {
                    string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery1 = "insert into [dbo].[AlliedField] (AlliedFieldName) values (@name)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@name", obj.AlliedFieldName);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                }
            }
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
            String sql = "SELECT SupervisorName FROM [dbo].[Supervisor]";
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
        [HttpGet]
        public ActionResult Student()
        {
            
            var getitemlist = db.Semesters.ToList();
            SelectList list = new SelectList(getitemlist, "SemesterNumber", "SemesterNumber");
            ViewBag.semesterlist = list;

            var getitemlist1 = db.Supervisors.ToList();
            SelectList list1 = new SelectList(getitemlist1, "SupervisorName", "SupervisorName");
            ViewBag.semesterlist1 = list1;


            var getitemlist2 = db.Co_Supervisor.ToList();
            SelectList list2 = new SelectList(getitemlist2, "CoSupervisorName", "CoSupervisorName");
            ViewBag.semesterlist2 = list2;

            //List<Supervisor> count0 = new List<Supervisor>();
            //var count1 = db.Supervisors.Count();
            //count0 = count1
            //List<SelectListItem> item8 = new List<SelectListItem>();
            //foreach (var c in count0)
            //{
            //    item8.Add(new SelectListItem
            //    {
            //        Text = c.country,
            //        Value = c.countryid.ToString()
            //    });
            //}

            //ViewBag.countrydrop = item8;
            var items = db.Supervisors.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }

            // Model1 semesterobj1 = new Model1();

            //var items = semesterobj1.Supervisors.ToList();
            //Model1 semesterobj1 = new Model1();
            List<Supervisor> count = new List<Supervisor>();
            count = items;

            //List<Companyregister> coun = new List<Companyregister>();
            //coun = ds.getcountry();

            List<SelectListItem> item8 = new List<SelectListItem>();
            foreach (var c in count)
            {
                item8.Add(new SelectListItem
                {

                    Value = c.SupervisorName
                });
            }

            ViewBag.countrydrop = item8;
            //Model1 semesterobj1 = new Model1();
            //var getitemlist1 = semesterobj1.Supervisors.ToList();
            //SelectList list1 = new SelectList(getitemlist1, "SupervisorName", "SupervisorName");
            //ViewBag.semesterlist = list1;
            return View();
            //Model1 Supervisorobj = new Model1();
            //var getitemlist1 = Supervisorobj.Supervisors.ToList();
            //SelectList list1 = new SelectList(getitemlist1, "SupervisorName", "SupervisorName");
            //ViewBag.Supervisorlist = list1;
            //return View();
        }
        [HttpGet]
        public ActionResult SupervisorandCosupervisor()
        {
            var getitemlist = db.Semesters.ToList();
            SelectList list = new SelectList(getitemlist, "SemesterNumber", "SemesterNumber");
            ViewBag.semesterlist = list;
            //SupervisorandCosupervisorVM model = new SupervisorandCosupervisorVM();
            //model.Supervisors = db.Supervisors.ToList();
            //ViewBag.data = model.Supervisors;
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
        [HttpGet]
        public ActionResult AddSemester()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSemester(AddSemesterVM obj)
        {
            if (obj.SemesterNumber!= 0)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Model11"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery1 = "insert into [dbo].[Semester] (SemesterNumber) values (@name)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                sqlconn.Open();
                sqlcomm.Parameters.AddWithValue("@name", obj.SemesterNumber);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();

            }
            return View("AddSemester");
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