using System.Collections.Generic;

namespace nflSurvivior.Core.Domain
{
    public class Week : Entity
    {
        public int Number { get; set; }
        public List<Game> Games { get; set; }   
    }
}