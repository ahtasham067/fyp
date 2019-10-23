using FYP.Models;
using FYP.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
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
        //[HttpGet]
        //public ActionResult Students()
        //{
        //    string mainconn = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        //    SqlConnection sqlconn = new SqlConnection(mainconn);
        //    String sql = "SELECT SupervisorName FROM [dbo].[Supervisor]";
        //    SqlCommand cmd = new SqlCommand(sql, sqlconn);

        //    var model = new List<Supervisor>();
        //    using (SqlConnection conn = new SqlConnection(mainconn))
        //    {
        //        sqlconn.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            var student = new Supervisor();
        //            student.SupervisorName = rdr["SupervisorName"].ToString();
        //    model.Add(student);
        //        }
        //        sqlconn.Close();

        //    }

        //    return View(model);
        //}
        [HttpGet]
        public ActionResult Student()
        {

            var getitemlist = db.Semesters.ToList();
            SelectList list = new SelectList(getitemlist, "SemesterId", "SemesterNumber");
            ViewBag.semesterlist = list;

            var getitemlist1 = db.Supervisors.ToList();
            SelectList list1 = new SelectList(getitemlist1, "SupervisorId", "SupervisorName");
            ViewBag.semesterlist1 = list1;


            var getitemlist2 = db.Co_Supervisor.ToList();
            SelectList list2 = new SelectList(getitemlist2, "CoSupervisorId", "CoSupervisorName");
            ViewBag.semesterlist2 = list2;


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Student(StudentVM obj, HttpPostedFileBase ProposalFile, HttpPostedFileBase SrsFile, HttpPostedFileBase SreFile, HttpPostedFileBase Code, HttpPostedFileBase Prototype, HttpPostedFileBase FinalReport)
        {
            if (ProposalFile != null)
            {
                    string filename = Path.GetFileName(ProposalFile.FileName);
                    ProposalFile.SaveAs(Server.MapPath("/ProposalFiles/" + filename));
                    string mainconn = ConfigurationManager.ConnectionStrings["Model15"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery1 = "insert into [dbo].[Project] (Title,Supervisor,CoSupervisor,Summary,Objective,Scope,ToolsAndTechnologies,ProposalFileType,ProposalFilePath,ProposalFileName) values (@Title,@Supervisor,@CoSupervisor,@Summary,@Objective,@Scope,@ToolsAndTechnologies,@ProposalFileType,@ProposalFilePath,@ProposalFileName)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                    byte[] bytes;
                    using (BinaryReader br = new BinaryReader(ProposalFile.InputStream))
                    {
                        bytes = br.ReadBytes(ProposalFile.ContentLength);

                    }
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@ProposalFileName",filename);
                    sqlcomm.Parameters.AddWithValue("@Title", obj.Title);
                    sqlcomm.Parameters.AddWithValue("@Supervisor", obj.Supervisor);
                    sqlcomm.Parameters.AddWithValue("@CoSupervisor", obj.CoSupervisor);
                    sqlcomm.Parameters.AddWithValue("@Summary", obj.Summary);
                    sqlcomm.Parameters.AddWithValue("@Objective", obj.Objective);
                    sqlcomm.Parameters.AddWithValue("@Scope", obj.Scope);
                    sqlcomm.Parameters.AddWithValue("@ToolsAndTechnologies", obj.ToolsAndTechnologies);
                    sqlcomm.Parameters.AddWithValue("@ProposalFileType", ProposalFile.ContentType);
                    sqlcomm.Parameters.AddWithValue("@ProposalFilePath", @"/ProposalFiles/" + filename);
                    sqlcomm.ExecuteNonQuery();
                    
                    StudentVM vm = new StudentVM();
                    var projectid4 = obj.ProjectId;


                    sqlconn.Close();
                    Project p = new Project();
                    var ProjectId3 = p.ProjectId;
            }
            else
            {
                if (SrsFile != null)
                {
                    string filename = Path.GetFileName(SrsFile.FileName);
                    SrsFile.SaveAs(Server.MapPath("/SrsFiles/" + filename));
                    string mainconn = ConfigurationManager.ConnectionStrings["Model15"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery1 = "UPDATE [dbo].[Project] SET SrsFileType=@SrsFileType,SrsFilePath=@SrsFilePath,SrsFileName=@SrsFileName WHERE ProjectId=@ProjectId";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                    byte[] bytes;
                    using (BinaryReader br = new BinaryReader(SrsFile.InputStream))
                    {
                        bytes = br.ReadBytes(SrsFile.ContentLength);

                    }
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@SrsFileName", filename);
                    sqlcomm.Parameters.AddWithValue("@SrsFileType", SrsFile.ContentType);
                    sqlcomm.Parameters.AddWithValue("@ProjectId", 1);
                    sqlcomm.Parameters.AddWithValue("@SrsFilePath", @"/SrsFiles/" + filename);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }
                else
                {
                    if (SreFile != null)
                    {
                        var supportedTypes = new[] { "zip", "rar"};
                        var fileExt = System.IO.Path.GetExtension(SreFile.FileName).Substring(1);
                        //if (!supportedTypes.Contains(fileExt))
                        //{
                        //    ErrorMessage = "File Extension Is InValid - Only Upload WORD/PDF/EXCEL/TXT File";
                        //    return ErrorMessage;
                        //}

                        if (supportedTypes.Contains(fileExt))
                        {

                            string filename = Path.GetFileName(SreFile.FileName);
                            SreFile.SaveAs(Server.MapPath("/SreFiles/" + filename));
                            string mainconn = ConfigurationManager.ConnectionStrings["Model15"].ConnectionString;
                            SqlConnection sqlconn = new SqlConnection(mainconn);
                            string sqlquery1 = "UPDATE [dbo].[Project] SET SreFileType=@SreFileType,SreFilePath=@SreFilePath,SreFileName=@SreFileName WHERE ProjectId=@ProjectId";
                            SqlCommand sqlcomm = new SqlCommand(sqlquery1, sqlconn);
                            byte[] bytes;
                            using (BinaryReader br = new BinaryReader(SreFile.InputStream))
                            {
                                bytes = br.ReadBytes(SreFile.ContentLength);

                            }
                            sqlconn.Open();
                            sqlcomm.Parameters.AddWithValue("@SreFileName", filename);
                            sqlcomm.Parameters.AddWithValue("@SreFileType", SreFile.ContentType);
                            sqlcomm.Parameters.AddWithValue("@ProjectId", 1);
                            sqlcomm.Parameters.AddWithValue("@SreFilePath", @"/SreFiles/" + filename);
                            sqlcomm.ExecuteNonQuery();
                            sqlconn.Close();
                        }
                    }
                }

            }
            

            return RedirectToAction("Student");
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