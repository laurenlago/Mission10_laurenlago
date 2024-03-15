namespace API2_Mission10_Lauren.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
        IEnumerable<Bowler> GetBowlersWithTeams(string[] teamNames);
    }
}
