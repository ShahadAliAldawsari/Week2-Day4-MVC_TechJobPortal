using TechJobPortal.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using static TechJobPortal.Models.JobListing;


namespace TechJobPortal.Controllers
{
    public class JobController : Controller
    {
        private static List<JobListing> jobList = new List<JobListing>
            {
                new JobListing{Id=1, Title="Web Dev", CompanyName="Elm", Location="KSA", JobType = JobType.Full_time, PostedDate = DateTime.Now},
                new JobListing{Id=1, Title="AI Eng", CompanyName="Elm", Location="KSA", JobType = JobType.Part_time, PostedDate = DateTime.Now},
                new JobListing{Id=1, Title="Data Eng", CompanyName="Elm", Location="Remote", JobType = JobType.Remote, PostedDate = DateTime.Now},
                new JobListing{Id=1, Title="App Dev", CompanyName="Elm", Location="KSA", JobType = JobType.Full_time, PostedDate = DateTime.Now},
                new JobListing{Id=1, Title="IOS Dev", CompanyName="Elm", Location="KSA", JobType = JobType.Contract, PostedDate = DateTime.Now},

            };

        // 🟢 Index: list of job listings.
        public IActionResult Index()
        {
            return View(jobList);
        }

        // 🟢 Details: details of a selected job.
        public IActionResult Details()
        {
            return View(jobList);
        }
    }
}
