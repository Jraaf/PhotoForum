using Microsoft.EntityFrameworkCore;
using PhotoForum.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoForum.DAL;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<Disscusion> Disscusions { get; set; }
    public DbSet<Photo> Photoes { get; set; }
    public DbSet<Reply> Replies { get; set; }
    public DbSet<User> Users { get; set; }

}
