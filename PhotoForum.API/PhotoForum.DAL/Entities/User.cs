using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.DAL.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }=string.Empty;
    public string Email { get; set; }=string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public byte[] ProfilePicture { get; set; }
}
