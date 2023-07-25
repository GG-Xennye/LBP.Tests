using LBP.Tests.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LBP.Tests.Data;

public partial class FlashScoreDataContext : DbContext
{
    public FlashScoreDataContext(DbContextOptions<FlashScoreDataContext> options)
        : base(options)
    {
    }

    public DbSet<Match> Matches { get; set; } = null!;
}