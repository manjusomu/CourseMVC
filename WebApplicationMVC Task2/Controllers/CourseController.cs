using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC_Task2.Models;

namespace WebApplicationMVC_Task2.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courseList = new List<Course>()
        {
            new Course(){CId=101,CName="C" ,CFee=20000,Technology="Vs",CStartDate=new DateTime(day:2,month:5,year:2022),CEndDate=new DateTime(day:3,month:7,year:2022)},
                        new Course(){CId=106,CName="C#" ,CFee=32000,Technology="Mssql",CStartDate=new DateTime(day:5,month:8,year:2022),CEndDate=new DateTime(day:10,month:10,year:2022)},
            new Course(){CId=102,CName="java" ,CFee=25000,Technology="Microsoft",CStartDate=new DateTime(day:15,month:9,year:2023),CEndDate=new DateTime(day:14,month:11,year:2023)},
            new Course(){CId=103,CName="Python" ,CFee=45000,Technology=".NET",CStartDate=new DateTime(day:17,month:2,year:2023),CEndDate=new DateTime(day:20,month:5,year:2023)},
            new Course(){CId=104,CName="Angular" ,CFee=60000,Technology="Testing",CStartDate=new DateTime(day:13,month:6,year:2022),CEndDate=new DateTime(day:15,month:8,year:2022)},

        };
        public ActionResult Index()
        {
            return View(courseList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create( Course c)
        {
            if (ModelState.IsValid)
            {
                courseList.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }
    }
}