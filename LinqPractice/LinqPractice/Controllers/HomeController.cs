using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LinqPractice.Models;
using System.Xml.Serialization;
using System.IO;
//using System.Web.Mvc;
  
namespace LinqPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // StudentData studentDataList = new StudentData();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            //using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
            //{
            //    searial.Serialize(fs, StudentData.GetStudents());
            //}
        }

        public IActionResult Index()
        {
            return View();
        }
  //      [ChildActionOnly]
        public IActionResult _StudentData()
        {
            return PartialView(StudentData.GetStudents());
        }
        public IActionResult InputFilterView() 
        {
            Student obj = new Student();
            return View(obj);
        }
        
        public IActionResult Pagination(int id)
        {
            int noOfItem = 6;
            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }
            List<Student> TempList = newList.Skip((id-1) * noOfItem).Take(noOfItem).ToList();
            TwoModel model = new TwoModel();
            model.StudentList = TempList;
            model.FilterInput = new Student();
            return View("Privacy", model);
        }
        public IActionResult Privacy()
        {
            int noOfItem = 6;
            TwoModel model = new TwoModel();
            //model.StudentList = StudentData.GetStudents();
            model.FilterInput = new Student();
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                model.StudentList = searial.Deserialize(fs) as List<Student>;
            }
            List<Student> TempList = model.StudentList.Skip(0).Take(noOfItem).ToList();
            //ViewData["StudentList"] = StudentData.GetStudents();
            // Student obj = new Student();
            model.StudentList = TempList;
            return View(model);
        }
        public IActionResult AddStudent(Student Model)
        {
            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }
            newList.Add(new Student() { StudentID = Model.StudentID, StudentName = Model.StudentName, Age = Model.Age });
            TwoModel model = new TwoModel();
            model.StudentList = newList;
            model.FilterInput = Model;
           
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
            {
                searial.Serialize(fs, newList);
            }
            return View("Privacy", model);
        }
        [HttpPost]
        public IActionResult InputFilterSubmit(Student Model)
        {
            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }
            var updatedList = (from student in newList where (Model.Age == student.Age || Model.StudentID == student.StudentID || Model.StudentName == student.StudentName) select student).ToList();
            // ViewData["StudentList"] = updatedList;
            var orderByResult = from s in newList orderby s.StudentName descending select s;
            var thenByDescResult = newList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            var innerJoin = from n in newList 
                            join sd in StudentData.GetStudents() 
                            on n.StudentID equals sd.StudentID 
                            select n;
            TwoModel model = new TwoModel();
            model.StudentList = updatedList;
            model.FilterInput = Model;
            //using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
            //{
            //    searial.Serialize(fs, updatedList);
            //}
            return View("Privacy", model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
