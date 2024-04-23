using Microsoft.EntityFrameworkCore;
using PhotoForum.DAL.Entities;
using PhotoForum.DAL.Repository.Base;
using PhotoForum.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.DAL.Repository
{
    public class UserRepository : Repo<User, int>, IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<User> GetAsync(string Username)
        {
            var data = await _context.Users.FirstOrDefaultAsync(u => u.Username == Username);
            if (data == null)
            {
                return null;
            }
            return data;
        }
    }
}
