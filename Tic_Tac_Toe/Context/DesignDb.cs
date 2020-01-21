using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tic_Tac_Toe.Context
{ 
    public class DesignDb : IDesignTimeDbContextFactory<ScoreDbEntities>
    {
     public ScoreDbEntities CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ScoreDbEntities>();
            var connectionString = @"Dat Source=cars.db;";
            builder.UseSqlite(connectionString);
            return new ScoreDbEntities(builder.Options);
        }
   }
}
