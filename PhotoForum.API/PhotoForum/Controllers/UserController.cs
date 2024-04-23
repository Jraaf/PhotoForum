using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoForum.Attributes;
using PhotoForum.BLL.Services;
using PhotoForum.BLL.Services.Interfaces;
using PhotoForum.Common.DTO;
using PhotoForum.Common.Helper;

namespace PhotoForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        [Attributes.Authorize]
        public async Task<List<UserDTO>> GetAll()
        {
            return await _service.GetAll();
        }
        [HttpPost]
        public async Task<bool> Add(CreateUserDTO user)
        {
            return await _service.Add(user);
        }
        [HttpGet("{id}")]
        [Attributes.Authorize]
        public async Task<UserDTO?> GetById(int id)
        {
            return await _service.GetById(id);
        }
        [HttpPut]
        [Attributes.Authorize]
        public async Task<bool> Update(CreateUserDTO user, int id)
        {
            return await _service.Update(user, id);
        }
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticateRequest request)
        {
            var response = await _service.Authenticate(request);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
    }
}
