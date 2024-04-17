using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoForum.DAL.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public int ReplyId { get; set; }
        public byte[] Image { get; set; }
        public Reply? PreviousReply { get; set; }
    }
}
