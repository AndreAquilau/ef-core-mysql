using Microsoft.AspNetCore.Mvc;
using AuthAPI.Data;
using AuthAPI.Models;
using AuthAPI.DTOs.UserDtos;


namespace AuthAPI.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class UserController : ControllerBase
    {
        private AuthContext _context;
        
        public UserController( AuthContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public ActionResult Create([FromBody] UserCreateDto userCreateDto)
        {
            try
            {
                var user = new User();

                user.Email = userCreateDto.Email;
                user.Senha = userCreateDto.Senha;

                _context.Users.Add(user);

                _context.SaveChanges();

                return CreatedAtAction(null, user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
