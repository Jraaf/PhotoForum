using PhotoForum.DAL.Entities;
using PhotoForum.DAL.Repository.Base;
using PhotoForum.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.DAL.Repository
{
    public class ReplyRepository : Repo<Reply, int>, IReplyRepository
    {
        public ReplyRepository(ApplicationDbContext context)
            :base(context)
        {
            
        }
    }
}
