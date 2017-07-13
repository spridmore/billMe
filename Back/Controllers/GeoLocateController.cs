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
  public class LocationGeo
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
  public class LocationGeoTwo
  {
    public List<Result> results { get; set; }
    public int count { get; set; }
    public Page page { get; set; }
  }

  [Route("api/[controller]")]
  public class GeoLocatorController : Controller
  {
    // GET api/passedbill
    [HttpGet]
    public object Get()
    {
      var client = new HttpClient();
      var results = client.GetStringAsync("http://freegeoip.net/json/").Result;
      return JsonConvert.DeserializeObject(results);
    }
    [HttpGet("{zip}")]
    public object Get(string zip)
    {
      var client = new HttpClient();
      var results = client.GetStringAsync("https://congress.api.sunlightfoundation.com/legislators/locate?zip=" + zip).Result;
      return JsonConvert.DeserializeObject(results);
    }

  }
}