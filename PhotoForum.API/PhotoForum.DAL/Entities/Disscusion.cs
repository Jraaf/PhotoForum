using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.DAL.Entities;

public class Disscusion
{
    public int Id { get; set; }
    public string Header { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}
