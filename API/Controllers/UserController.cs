using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUser()
        {
            var user = await _repository.GetUsersAsync();

            return Ok(user);
        }
        [HttpPost("{id}")]
        public async Task<ActionResult<List<User>>> GetUser(int id, double latitude, double longitude, int distance, bool genders, int start_age, int end_age)
        {
            var user = await _repository.GetuserAsync(id, latitude, longitude, distance, genders, start_age, end_age);

            return Ok(user);
        }
    }
}