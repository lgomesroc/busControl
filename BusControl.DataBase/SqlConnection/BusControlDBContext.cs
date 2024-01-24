using Microsoft.EntityFrameworkCore;
using System;

namespace BusControl.Database.SqlConnection
{
    public class BusControlDBContext : DbContext
    {
        public BusControlDBContext(DbContextOptions<BusControlDBContext> options) : base(options)
        {
            options.Database = "BusControlDB";
            options.UseSqlServer();
        }

        var dbContext = new BusControlDBContext();

        if (dbContext.Database.EnsureCreated())
        {
            Console.WriteLine("Conexão com o banco de dados bem-sucedia!");
        }

        Console.WriteLine("Falhou a conexão com o banco de dados!");

    }
}
