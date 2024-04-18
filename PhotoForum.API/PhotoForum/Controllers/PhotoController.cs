using Microsoft.AspNetCore.Mvc;
using PhotoForum.BLL.Services.Interfaces;
using PhotoForum.Common.DTO;

namespace PhotoForum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService _service;
        public PhotoController(IPhotoService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<PhotoDTO> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }
        [HttpGet]
        public async IAsyncEnumerable<List<PhotoDTO>> GetAll()
        {
            yield return await _service.GetAllAsync();
        }
        [HttpPost]
        public async Task<bool> Post(CreatePhotoDTO obj)
        {
            return await _service.CreateAsync(obj);
        }
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<bool> Update(CreatePhotoDTO obj, int id)
        {
            return await _service.UpdateAsync(obj, id);
        }
    }
}
