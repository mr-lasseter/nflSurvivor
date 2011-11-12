using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Helpers;
using NHibernate.Cfg;
using NHibernate.Proxy.DynamicProxy;

namespace NflSurvivior.Core.Infrastructure.NHibernate
{
    public class NHibernateConfiguration
    {
        public static Configuration Configure(string context = "web")
        {
            var config = new NflSurvivorAutoMapping();

            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.FromConnectionStringWithKey("nflSurvivor")))
                .Mappings(x => x.AutoMappings.Add(AutoMap.AssemblyOf<NHibernateConfiguration>(config)
                    .Conventions.Setup(c =>
                                           {
                                               c.Add<CascadeAllConvention>();
                                               c.Add<CustomForeignKeyConvention>();
                                               c.Add<CustomForeignKeyNameConvention>();
                                           }
                    )))
                .ExposeConfiguration(x => x.SetProperty("current_session_context_class", context))
                .ExposeConfiguration(x => x.SetProperty("adonet.batch_size", "20"))
                .BuildConfiguration();
        }

      
    }
}