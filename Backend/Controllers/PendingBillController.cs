using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;

namespace Bills_Project.Controllers
{

  public class History
  {
    public bool active { get; set; }
    public string active_at { get; set; }
    public bool awaiting_signature { get; set; }
    public bool enacted { get; set; }
    public string senate_passage_result { get; set; }
    public string senate_passage_result_at { get; set; }
    public bool vetoed { get; set; }
    public string house_passage_result { get; set; }
    public string house_passage_result_at { get; set; }
  }

  public class Sponsor
  {
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string middle_name { get; set; }
    public object name_suffix { get; set; }
    public string nickname { get; set; }
    public string title { get; set; }
  }

  public class Urls
  {
    public string congress { get; set; }
    public string govtrack { get; set; }
  }

  public class UrlOptions
  {
    public string html { get; set; }
    public string pdf { get; set; }
    public string xml { get; set; }
  }

  public class LastVersion
  {
    public string version_code { get; set; }
    public string issued_on { get; set; }
    public string version_name { get; set; }
    public string bill_version_id { get; set; }
    public UrlOptions urls { get; set; }
    public int pages { get; set; }
  }

  public class Result
  {
    public string bill_id { get; set; }
    public string bill_type { get; set; }
    public string chamber { get; set; }
    public List<object> committee_ids { get; set; }
    public int congress { get; set; }
    public int cosponsors_count { get; set; }
    public object enacted_as { get; set; }
    public History history { get; set; }
    public string introduced_on { get; set; }
    public string last_action_at { get; set; }
    public string last_version_on { get; set; }
    public string last_vote_at { get; set; }
    public int number { get; set; }
    public string official_title { get; set; }
    public object popular_title { get; set; }
    public List<object> related_bill_ids { get; set; }
    public string short_title { get; set; }
    public Sponsor sponsor { get; set; }
    public string sponsor_id { get; set; }
    public Urls urls { get; set; }
    public int withdrawn_cosponsors_count { get; set; }
    public LastVersion last_version { get; set; }
  }

  public class Page
  {
    public int count { get; set; }
    public int per_page { get; set; }
    public int page { get; set; }
  }

  public class RootObject
  {
    public List<Result> results { get; set; }
    public int count { get; set; }
    public Page page { get; set; }
  }

  [Route("api/[controller]")]
  public class PendingBillController : Controller
  {
    // GET api/pendingbill
    [HttpGet]
    public object Get()
    {
      var client = new HttpClient();
      var results = client.GetStringAsync("https://congress.api.sunlightfoundation.com/bills?history.active=true&order=last_action_at").Result;
      return JsonConvert.DeserializeObject(results);
    }
    // GET api/pendingbill/subject
    [HttpGet("{subject}")]
    public object Get(string subject)
    {
      var client = new HttpClient();
      var results = client.GetStringAsync("https://congress.api.sunlightfoundation.com/bills/search?query="  + subject + "&history.active=true&order=last_action_at").Result;
      return JsonConvert.DeserializeObject(results);
    }
  }
}