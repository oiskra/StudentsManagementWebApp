using Microsoft.AspNetCore.Mvc;
using System;
using ProjektZaliczeniowyDziekanat.DAL.Models;
using ProjektZaliczeniowyDziekanat.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ProjektZaliczeniowyDziekanat.Controllers
{
    public class StudentController : Controller
    {
        private readonly IObslugaStudent obslugaStudent;
        

        public StudentController(IObslugaStudent obslugaStudent)
        {
            this.obslugaStudent = obslugaStudent;
        }

        [HttpGet]
        [Route("Student/Home")]
        public IActionResult Index()
        {
            Student student = obslugaStudent.ZalogowanyStudent(HttpContext.Session.GetInt32("studentID"));

            if (student == null)
                return BadRequest();
            else
                return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> Dane()
        {           
            StudentDTO studentDTO = await obslugaStudent.ZalogowanyStudentDTOAsync(HttpContext.Session.GetInt32("studentID"));

            if (studentDTO == null)
                return BadRequest();

            else
            {
                Platnosc platnosc = obslugaStudent.ZnajdzPlatnosc(HttpContext.Session.GetInt32("studentID"));
                if (platnosc == null)
                {
                    ViewData["platnosc"] = "NIE OPŁACONO";
                    ViewData["dataPlatnosci"] = "NIE OPŁACONO";
                }
                else
                {
                    ViewData["platnosc"] = platnosc.Kwota;
                    ViewData["dataPlatnosci"] = platnosc.DataPlatnosci.ToString("d");
                }

                return View(studentDTO);
            }
        }


        [HttpGet]
        public async Task<IActionResult> PlanZajec(string sortOrder, string searchString)
        {
            Student ZalStudent = obslugaStudent.ZalogowanyStudent(HttpContext.Session.GetInt32("studentID"));

            if (ZalStudent == null)
                return BadRequest();
            else
            {
                ViewData["DateSortPar"] = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
                ViewData["NameSortPar"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewData["CurrentFilter"] = searchString;
                var list = await obslugaStudent.WyswietlZajeciaAsync(ZalStudent, sortOrder, searchString);


                return View(list);
            }
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var student =  obslugaStudent.ZalogowanyStudent(HttpContext.Session.GetInt32("studentID"));
            ViewData["nadawca"] = $"{student.Imie} {student.Nazwisko}";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Oceny()
        {
            List<StudentOceny> oceny = await obslugaStudent.PobierzOcenyStudentaAsync(HttpContext.Session.GetInt32("studentID")); 
            if(oceny.Any())
            {
                oceny.ForEach(x => x.Zajecia = obslugaStudent.PobierzZajecia(x.ZajeciaID));
                oceny.ForEach(x => x.Student = obslugaStudent.ZalogowanyStudent(x.StudentID));

                return View(oceny);
            }

            return View(oceny);
        }
    }
}
