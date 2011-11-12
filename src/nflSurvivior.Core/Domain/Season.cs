using System.Collections.Generic;

namespace nflSurvivior.Core.Domain
{
    public class Season : Entity
    {
        public virtual int CurrentWeek { get; set; }
        public virtual List<Week> Weeks { get; set; }
    }
}