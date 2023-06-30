using apiGestores.models;
using Microsoft.EntityFrameworkCore;

//AppDbContext is the context for our SQL DB connection.

namespace apiGestores.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                    
        }

        //gestores_bd must be named the same as the table in which we will have our registers.
        //get-set are important for the database, it allows the read and modification of the datatable registers
        public DbSet<Gestores_Bd> gestores_bd { get; set; }
    }
}
