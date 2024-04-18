using Microsoft.AspNetCore.Mvc;
using PhotoForum.BLL.Services.Interfaces;
using PhotoForum.Common.DTO;

namespace PhotoForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisscussionController : ControllerBase
    {
        private readonly IDisscussionService _service;
        public DisscussionController(IDisscussionService service)
        {
            _service=service;
        }
        [HttpGet("{id}")]
        public async Task<DisscussionDTO> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }
        [HttpGet]
        public async IAsyncEnumerable<List<DisscussionDTO>> GetAll()
        {
            yield return await _service.GetAllAsync();
        }
        [HttpPost]
        public async Task<bool> Post(CreateDisscussionDTO obj)
        {
            return await _service.CreateAsync(obj);
        }
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<bool> Update(CreateDisscussionDTO obj, int id)
        {
            return await _service.UpdateAsync(obj, id);
        }
    }
}
