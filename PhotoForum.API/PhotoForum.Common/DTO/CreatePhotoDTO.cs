using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.Common.DTO
{
    public class CreatePhotoDTO
    {
        public int ReplyId { get; set; }
        public byte[] Image { get; set; }
    }
}
