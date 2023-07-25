namespace LBP.Tests.Data.Models;

public class Match
{
    public Match()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}