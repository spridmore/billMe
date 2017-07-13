using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Net.Http;


namespace Bills_Project_Backend.Controllers
{
  public class RepOne
  {
    public string ip { get; set; }
    public string country_code { get; set; }
    public string country_name { get; set; }
    public string region_code { get; set; }
    public string region_name { get; set; }
    public string city { get; set; }
    public string zip_code { get; set; }
    public string time_zone { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public int metro_code { get; set; }
  }
  public class RepTwo
  {
    public List<Result> results { get; set; }
    public int count { get; set; }
    public Page page { get; set; }
  }

  [Route("api/[controller]")]
  public class RepContactDataController : Controller
  {
    // GET api/repcontactdata
    [HttpGet]
    public object Get()
    {
      var client = new HttpClient();
      var results = client.GetStringAsync("https://congress.api.sunlightfoundation.com/legislators?bioguide_id=H001075&all_legislators=true/").Result;
      return JsonConvert.DeserializeObject(results);
    }
        // GET api/RepContactData/id

    [HttpGet("{id}")]
    public object Get(string id)
    {
      var client = new HttpClient();
      var results = client.GetStringAsync("https://congress.api.sunlightfoundation.com/legislators?bioguide_id=" + id + "&all_legislators=true/").Result;
      return JsonConvert.DeserializeObject(results);
    }

  }
}