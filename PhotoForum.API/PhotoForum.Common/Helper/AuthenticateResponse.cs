using Microsoft.EntityFrameworkCore.ChangeTracking;
using PhotoForum.DAL.Entities;

namespace PhotoForum.Common.Helper;
public class AuthenticateResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
    public AuthenticateResponse(User user,string token)
    {
        Id = user.Id;
        Username = user.Username;
        Email = user.Email;
        Token = token;
    }
}
