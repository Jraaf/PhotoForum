using AutoMapper;
using PhotoForum.Common.DTO;
using PhotoForum.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.Common.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDTO, User>();
            CreateMap<User,UserDTO>();
        }
    }
}
