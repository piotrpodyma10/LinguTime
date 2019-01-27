using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinguTime.Domain;
using LinguTime.Domain.Dto;
using LinguTime.Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace LinguTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly LinguTimeContext _context;

        public UsersController(LinguTimeContext context)
        {
            _context = context;
        }

        [HttpPost("AddUser")]
        [Authorize]
        public IActionResult AddUser([FromBody] CreateUserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(new UsersDto
            {
                Id = user.Id
            });
            _context.SaveChanges();


            return Ok(user.Id);
        }
    }
}
