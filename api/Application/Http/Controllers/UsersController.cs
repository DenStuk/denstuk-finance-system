using System.Threading.Tasks;
using api.Controllers;
using api.Entities;
using api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Application.Http.Controllers
{
    public class UsersController : BaseController
    {
        private readonly UserService _service;
        public UsersController(UserService userService)
        {
            _service = userService;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            return await _service.GetOneById(id);
        }
    }
}