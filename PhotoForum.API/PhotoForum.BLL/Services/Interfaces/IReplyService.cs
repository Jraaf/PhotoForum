using PhotoForum.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.BLL.Services.Interfaces
{
    public interface IReplyService
    {
        Task<List<ReplyDTO>> GetAllAsync();
        Task<ReplyDTO> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreateReplyDTO replyDTO);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(CreateReplyDTO photoDTO, int Id);
    }
}
