using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Db
{
    public class UbicuaDbContext : DbContext
    {
        private const string _connection = "Server=DESKTOP-33G4R31\\SQLEXPRESS;Initial Catalog=TechGadget;User ID=sa;Password=Gestion01;TrustServerCertificate=True;";
        public DbSet<Dato> Datos { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);
        }
    }
}
