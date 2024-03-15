namespace API2_Mission10_Lauren.Data
{
    public class EFBowlerRepository: IBowlerRepository
    {

        private BowlerContext _context;

        public EFBowlerRepository(BowlerContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;

        public IEnumerable<Bowler> GetBowlersWithTeams(string[] teamNames)
        {
            var joinedData = from bowler in _context.Bowlers
                             join team in _context.Teams
                             on bowler.TeamId equals team.TeamId
                             where teamNames.Contains(team.TeamName) //Filter teams based on list passed in
                             select new
                             {
                                 BowlerId = bowler.BowlerId,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamID = bowler.TeamId,
                                 TeamName = team.TeamName
                             };

            var bowlersWithTeams = joinedData
                .Select(j => new Bowler
                {
                    BowlerId = j.BowlerId,
                    BowlerLastName = j.BowlerLastName,
                    BowlerFirstName = j.BowlerFirstName,
                    BowlerMiddleInit = j.BowlerMiddleInit,
                    BowlerAddress = j.BowlerAddress,
                    BowlerCity = j.BowlerCity,
                    BowlerState = j.BowlerState,
                    BowlerZip = j.BowlerZip,
                    BowlerPhoneNumber = j.BowlerPhoneNumber,
                    Team = new Team { TeamName = j.TeamName }
                })
                .ToList();

            return bowlersWithTeams;
        }

    }
}
