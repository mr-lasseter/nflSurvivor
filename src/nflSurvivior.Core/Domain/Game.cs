namespace nflSurvivior.Core.Domain
{
    public class Game : Entity
    {
        public Team VisitingTeam { get; set; }
        public int VisitingTeamScore { get; set; }

        public Team HomeTeam { get; set; }
        public int HomeTeamScore { get; set; }
    }
}