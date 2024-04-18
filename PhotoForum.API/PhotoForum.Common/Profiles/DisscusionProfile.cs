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
    public class DisscusionProfile:Profile
    {
        public DisscusionProfile()
        {
            CreateMap<Disscusion, DisscusionDTO>();
            CreateMap<CreateDisscusionDTO, Disscusion>();
        }
    }
}
