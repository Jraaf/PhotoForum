﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.Common.DTO
{
    public class CreateDisscusionDTO
    {
        public int Id { get; set; }
        public string Header { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }
}
