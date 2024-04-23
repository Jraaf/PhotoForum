using Microsoft.AspNetCore.Mvc;
using PhotoForum.BLL.Services.Interfaces;
using PhotoForum.Common.DTO;

namespace PhotoForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService _service;
        public ReplyController(IReplyService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<ReplyDTO> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }
        [HttpGet]
        public async Task<List<ReplyDTO>> GetAll()
        {
            return await _service.GetAllAsync();
        }
        [HttpPost]
        public async Task<bool> Post(CreateReplyDTO obj)
        {
            return await _service.CreateAsync(obj);
        }
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<bool> Update(CreateReplyDTO obj, int id)
        {
            return await _service.UpdateAsync(obj, id);
        }
    }
}
