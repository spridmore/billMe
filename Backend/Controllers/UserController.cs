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
    public class User {
      public string FirstName {get; set;}
      public string LastName {get; set;}
      public string UserName {get; set;}
      public string Password {get; set;}
      public int UserId {get; set;}
    }

    
    [Route("api/[controller]")]
    public class UserController : Controller
    {
      private readonly UserContext _context;
      public UserController(UserContext context) {
        _context = context;
      }
        // GET api/user
        [HttpGet]
        public IEnumerable<User> Get()
        {
          _context.SaveChanges();
          return _context.Users;
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public User Get(int id)
        {             
            foreach(User x in _context.Users)
             if(x.UserId == id) {
              return x;
             }
             return null;
        } 

        // POST api/user
        [HttpPost]
        public void Post([FromBody]User value)
        {          
          _context.Add(value);
          _context.SaveChanges();
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }}