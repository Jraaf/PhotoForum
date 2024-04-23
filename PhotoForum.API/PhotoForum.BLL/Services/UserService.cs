using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PhotoForum.BLL.Services.Interfaces;
using PhotoForum.Common.DTO;
using PhotoForum.Common.Exceptions;
using PhotoForum.Common.Helper;
using PhotoForum.DAL.Entities;
using PhotoForum.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _settings;
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;
        public UserService(IOptions<AppSettings> settings,IUserRepository repo,IMapper mapper)
        {
            _settings = settings.Value;
            _repo = repo;
            _mapper= mapper;
        }
        public async Task<bool> Add(CreateUserDTO userDTO)
        {
            var data=_mapper.Map<User>(userDTO);
            return await _repo.AddAsync(data);
        }

        public async Task<List<UserDTO>> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return _mapper.Map<List<UserDTO>>(data);
        }

        public async Task<UserDTO?> GetById(int id)
        {
            var data=await _repo.GetAsync(id);
            if(data == null)
            {
                throw new NotFoundException(id);
            }
            return _mapper.Map<UserDTO>(data);
        }

        public async Task<bool> Update(CreateUserDTO newUserDTO, int id)
        {
            var data = await _repo.GetAsync(id)
                ?? throw new NotFoundException(id);

            _mapper.Map(newUserDTO, data);

            return await _repo.UpdateAsync(data);
        }
        public async Task<AuthenticateResponse?> Authenticate(AuthenticateRequest request)
        {
            var user = await _repo.GetAsync(request.Username);

            if(user == null)
            {
                throw new NotFoundException(request.Username);
            }

            var token = await generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        private async Task<string> generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = await Task.Run(() => 
            {
                var key = Encoding.ASCII.GetBytes(_settings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject=new ClaimsIdentity(new[] { new Claim("id",user.Id.ToString())}),
                    Expires=DateTime.UtcNow.AddDays(1),
                    SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
                };
                return tokenHandler.CreateToken(tokenDescriptor);
            });
            return tokenHandler.WriteToken(token);
        }
    }
}
