using System.Collections.Generic;

namespace nflSurvivior.Core.Domain
{
    public class Season : Entity
    {
        public int CurrentWeek { get; set; }
        public List<Week> Weeks { get; set; }
    }
}