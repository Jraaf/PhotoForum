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
    public class PhotoRepository: Repo<Photo, int>, IPhotoRepository
    {
        public PhotoRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
