using PhotoForum.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.BLL.Services.Interfaces
{
    public interface IDisscussionService
    {
        Task<List<DisscussionDTO>> GetAllAsync();
        Task<DisscussionDTO> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreateDisscussionDTO publicationDTO);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(CreateDisscussionDTO publicationDTO, int Id);
    }
}
