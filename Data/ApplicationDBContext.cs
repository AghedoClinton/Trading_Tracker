namespace BulkyBookWeb.Data;
using Microsoft.EntityFrameworkCore;
using BulkyBookWeb.Models;
public class ApplicationDBContext  :DbContext{
    public ApplicationDBContext(DbContextOptions <ApplicationDBContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; } 
}