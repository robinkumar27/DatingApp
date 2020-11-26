using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Data;
using System.Collections.Generic;
using API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace API.Controllers
{
    
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
          [AllowAnonymous]
        [HttpGet]
        public async Task< ActionResult<IEnumerable<AppUser>>> GetUser()
        {
           return await _context.Users.ToListAsync();
            
        }
        //coded by robin on 19 Nov
        //new
        [Authorize]
        [HttpGet("{id}")]
        public async Task< ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync (id);
           

        }
    }
}