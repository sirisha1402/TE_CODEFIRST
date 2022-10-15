using TE_CODEFIRST.Models;
using Microsoft.EntityFrameworkCore;

namespace TE_CODEFIRST.Data
{
    public class TraineeDbContext : DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }

        public DbSet<Trainee> Trainees { get; set; }

    }
}