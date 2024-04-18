using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.Common.DTO
{
    public class CreateReplyDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReplyId { get; set; } = 0;
        public int DesscusionId { get; set; }
        public string Text { get; set; } = string.Empty;

    }
}
