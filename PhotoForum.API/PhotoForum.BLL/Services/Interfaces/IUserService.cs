using PhotoForum.Common.DTO;
using PhotoForum.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<AuthenticateResponse?> Authenticate(AuthenticateRequest request);
        Task<List<UserDTO>> GetAll();
        Task<UserDTO?> GetById(int id);
        Task<bool> Add(CreateUserDTO userDTO);
        Task<bool> Update(CreateUserDTO newUserDTO, int id);
    }
}
