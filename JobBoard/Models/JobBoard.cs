using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    private string _title;
    private string _description;
    private Dictionary<string, string> _contact = new Dictionary<string, string>();
    private static List<Job> _listOfJobs = new List<Job>(){};

    public Job(string title, string description, string name, string phoneNumber, string email)
    {
      _title = title;
      _description = description;
      _contact.Add("name", name);
      _contact.Add("phoneNumber", phoneNumber);
      _contact.Add("email", email);
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetContactName()
    {
      return _contact["name"];
    }
    public void SetContactName(string newName)
    {
      _contact["name"] = newName;
    }
    public string GetContactPhoneNumber()
    {
      return _contact["phoneNumber"];
    }
    public void SetContactPhoneNumber(string newPhoneNumber)
    {
      _contact["phoneNumber"] = newPhoneNumber;
    }
    public string GetContactEmail()
    {
      return _contact["email"];
    }
    public void SetContactEmail(string newEmail)
    {
      _contact["email"] = newEmail;
    }
    public static List<Job> GetList()
    {
      return _listOfJobs;
    }
    public void Save()
    {
      _listOfJobs.Add(this);
    }
  }
}
