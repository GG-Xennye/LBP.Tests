using Microsoft.EntityFrameworkCore;

namespace LBP.Tests.Data;

public partial class FlashScoreDataContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseInMemoryDatabase("FlashScores");
        }
    }
}