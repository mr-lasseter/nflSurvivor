using System;
using FluentNHibernate;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace NflSurvivior.Core.Infrastructure.NHibernate
{
    public class CascadeAllConvention : IHasManyConvention, IHasOneConvention, IReferenceConvention
    {
        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Cascade.AllDeleteOrphan();
        }

        public void Apply(IOneToOneInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IManyToOneInstance instance)
        {
            instance.Cascade.All();
        }
    }

    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
            {
                return string.Format("{0}Id", type.Name);
            }

            return string.Format("{0}Id", property.Name);
        }
    }

    public class CustomForeignKeyNameConvention : IHasManyConvention, IHasOneConvention, IReferenceConvention
    {
        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Key.ForeignKey(string.Format("{0}_{1}_FK", instance.Member.Name, instance.EntityType.Name));
        }

        public void Apply(IOneToOneInstance instance)
        {
            instance.ForeignKey(string.Format("{0}_{1}_FK", instance.Name, instance.EntityType.Name));
        }

        public void Apply(IManyToOneInstance instance)
        {
            instance.ForeignKey(string.Format("{0}_{1}_FK", instance.Name, instance.EntityType.Name));
        }
    }
}