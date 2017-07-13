using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bills_Project_Backend.Controllers
{
  public class Comment {
    public int Id {get; set;}
    public string Body {get; set;}
    public string Author {get; set;}
    public string commentBillId {get; set;}
  }

    [Route("api/[controller]")]
    public class CommentsController : Controller
    {
      private readonly CommentContext _context;
      public CommentsController(CommentContext context) {
        _context = context;
      }
        // GET api/comments
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
          _context.SaveChanges();
          return _context.Comments;
        }

        // GET api/comments/5
        [HttpGet("{id}")]
        public Comment Get(int id)
        {             
            foreach(Comment x in _context.Comments)
             if(x.Id == id) {
              return x;
             }
             return null;
        } 

        // POST api/comments
        [HttpPost]
        public void Post([FromBody]Comment value)
        {
          _context.Add(value);
          _context.SaveChanges();
        }

        // PUT api/comments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/comments/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
