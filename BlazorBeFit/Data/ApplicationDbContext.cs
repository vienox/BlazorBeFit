using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorBeFit.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Application DbSets - will be added in next step
    public DbSet<Models.ExerciseType> ExerciseTypes { get; set; }
    public DbSet<Models.TrainingSession> TrainingSessions { get; set; }
    public DbSet<Models.TrainingEntry> TrainingEntries { get; set; }
}
