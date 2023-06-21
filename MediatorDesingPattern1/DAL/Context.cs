using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MediatorDesingPattern1.DAL
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H080ONB\\SQLEXPRESS01;initial catalog=DbMediator; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
