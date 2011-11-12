using System;

namespace nflSurvivior.Core.Domain
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }
    }
}