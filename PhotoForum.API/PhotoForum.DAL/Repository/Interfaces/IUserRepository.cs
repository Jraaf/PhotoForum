﻿using PhotoForum.DAL.Entities;
using PhotoForum.DAL.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.DAL.Repository.Interfaces
{
    public interface IUserRepository:IRepo<User,int>
    {
        Task<User> GetAsync(string Username);
    }
}
