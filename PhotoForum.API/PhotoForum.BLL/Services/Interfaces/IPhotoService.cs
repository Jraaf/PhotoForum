using PhotoForum.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.BLL.Services.Interfaces
{
    public interface IPhotoService
    {
        Task<List<PhotoDTO>> GetAllAsync();
        Task<PhotoDTO> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreatePhotoDTO photoDTO);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(CreatePhotoDTO photoDTO, int Id);
    }
}
