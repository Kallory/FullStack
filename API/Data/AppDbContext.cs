using API.Models;
using Microsoft.EntityFrameworkCore; // library

namespace API.Data // Namespaces are used to organize code into a hierarchical structure, making it easier to manage and avoid naming conflicts.
{
    public class AppDbContext:DbContext
    {
        // the :base(options) is like calling super from a derived class in Java
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) // defines a public class named AppDbContext that inherits from DbContext. The DbContext class is a part of Entity Framework Core and serves as a bridge between your domain or entity classes and the database. It allows you to query and save data.
        {
            
        }

        public DbSet<Product> Products { get; set; }  //Products is Table Name in DB
    }
}