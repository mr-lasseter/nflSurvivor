namespace nflSurvivior.Core.Domain
{
    public class Game : Entity
    {
        public virtual  Team VisitingTeam { get; set; }
        public virtual int VisitingTeamScore { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual int HomeTeamScore { get; set; }
    }
}