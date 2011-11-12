namespace nflSurvivior.Core.Domain
{
    public class Team : Entity
    {
        public virtual string EspnTeamName { get; set; }
        public virtual string Location { get; set; }
        public virtual string Mascot { get; set; }
    }
}