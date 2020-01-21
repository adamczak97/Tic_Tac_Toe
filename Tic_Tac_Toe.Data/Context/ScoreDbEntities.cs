using Tic_Tac_Toe.App.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Tic_Tac_Toe.App.Context

{
   public class ScoreDbEntities : DbContext
    {
        public ScoreDbEntities(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ScoreEntity>()
                .ToTable("Scores");


        }
    }
}
