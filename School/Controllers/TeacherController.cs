using School.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace School.Controllers
{
    [RoutePrefix("school")]
    public class TeacherController : Controller
    {

        private static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher { Id = 1,Name="iti", BlogUrl = "http://www.iti.com",
                DateOfBirth=DateTime.Now.AddYears(-30),Email="andrewnashat47@yahoo.com",
            Mobile="01289855751", NationalId="01234567891234",Passowrd="1234a@",Salary=6000
            ,ismarried=true},
        };

        public ActionResult Index()
        {
            return View(Teachers);
        }

        public ActionResult Delete(int id)
        {
            Teachers.RemoveAll(e => e.Id == id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Teacher teach)
        {
            if (ModelState.IsValid)
            {
                teach.Id = Teachers.Max(x => x.Id) + 1;
                Teachers.Add(teach);
                return RedirectToAction("index");
            }
            else
            {
                return View("Create");
            }
  
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var T = Teachers.FirstOrDefault(x => x.Id == id);
            return View(T);
        }
        [HttpPost]
        public ActionResult Edit(Teacher tech)
        {
            if (ModelState.IsValid)
            {
                Teachers.RemoveAll(x => x.Id == tech.Id);
                Teachers.Add(tech);
                return RedirectToAction("index");
            }
            else
            {
                return View(tech);
            }
            
        }

    }
      

   
}