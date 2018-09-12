using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobBoardController : Controller
  {
    [HttpGet("/job")]
    public ActionResult Index()
    {
      //use GetList() to show existing list of cars
      List<Job> allJobs = Job.GetList();
      return View(allJobs);
    }
    [HttpGet("/job/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/job")]
    public ActionResult Create()
    {
      Job newJob = new Job(Request.Form["new-title"], Request.Form["new-description"], Request.Form["new-name"], Request.Form["new-phoneNumber"], Request.Form["new-email"]);
      // Dictonary newContact = new Dictionary();
      newJob.Save();
      // newContact.Save();
      List<Job> allJobs = Job.GetList();
      return View("Index", allJobs);

    }
  }
}
