using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenQuocviet.Data;
using NguyenQuocviet.Models;

namespace NguyenQuocviet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController
    {
        private readonly Dbcontext _context;

        public CommentController(Dbcontext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<comment>>> Getcomment()
        {
            return await _context.comments!.ToListAsync();
        }

        // GET: api/Users/5
       
    }
}
