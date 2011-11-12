using FluentNHibernate.Automapping;
using nflSurvivior.Core.Domain;

namespace NflSurvivior.Core.Infrastructure.NHibernate
{
  

    public class NflSurvivorAutoMapping : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(System.Type type)
        {
            return typeof (Entity).IsAssignableFrom(type);
        }
    }
}