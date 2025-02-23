﻿//HypertextAssassin Team(https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team)
//    Members:

//    Syed - p2652259 Github(https://github.com/No3Mc) Developer/System Analyst:
//    Umar - P2630030 Github(https://github.com/itsumarsoomro) Developer

//    Victor - P2622897 Github(https://github.com/VictorTooHauAn) System Analyst
//    Pierrick - P2611172 Github(https://github.com/Riick91) System Analyst

//    Wiki:

//    Syed: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Syed's-Wiki
//    Umar: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Umar's-Wiki
//    Victor: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Victor-Too-Hau-An---Coordinator-role
//    Pierrick: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Pierrick-Njiki-An-Coordinator-role



using CollegeProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProjectMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ViewResult Course()
        {
            //Computer Science Course
            CourseModel courseModel = new CourseModel();
            courseModel.CourseCode = "D16";
            courseModel.UCASCode = "D226";
            courseModel.CourseTitle = "Computer Science";
            courseModel.CourseDescription = "Computer science (CS) is the study of computers and algorithmic processes, including their principles, their hardware and software designs, their applications, and their impact on society.";
            courseModel.CourseTotalHours = 390;
            courseModel.CourseAvailability = "Available";
            courseModel.Accreditation = "BCS";
            courseModel.CourseCost = "16,250$";

            //Software Engineering Course
            CourseModel courseModel2 = new CourseModel();
            courseModel.CourseCode2 = "D16";
            courseModel.UCASCode2 = "D2126";
            courseModel.CourseTitle2 = "Software Engineering";
            courseModel.CourseDescription2 = "Software engineering is a detailed study of engineering to the design, development and maintenance of software. This is considered very important for the development of any software.";
            courseModel.CourseTotalHours2 = 290;
            courseModel.CourseAvailability2 = "Available";
            courseModel.Accreditation2 = "BCS";
            courseModel.CourseCost2 = "14,250$";

            //Cyber Security Course
            CourseModel courseModel3 = new CourseModel();
            courseModel.CourseCode3 = "D16";
            courseModel.UCASCode3 = "D212";
            courseModel.CourseTitle3 = "Cyber Security";
            courseModel.CourseDescription3 = "Cyber security is the application of technologies, processes and controls to protect systems, networks, programs, devices and data from cyber attacks. It aims to reduce the risk of cyber attacks and protect against the unauthorised exploitation of systems, networks and technologies.";
            courseModel.CourseTotalHours3 = 270;
            courseModel.CourseAvailability3 = "Available";
            courseModel.Accreditation3 = "BCS";
            courseModel.CourseCost3 = "17,250$";


            return View(courseModel);
        }

  
    }
}