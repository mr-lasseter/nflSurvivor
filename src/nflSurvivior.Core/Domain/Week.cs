using System.Collections.Generic;

namespace nflSurvivior.Core.Domain
{
    public class Week : Entity
    {
        public virtual int Number { get; set; }
        public virtual List<Game> Games { get; set; }   
    }
}