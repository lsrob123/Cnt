using System;

namespace Lx.Utilities.NetStandard.Persistence
{
    public static class PersistenceExtensions
    {
        public static TEntity WithValidKey<TEntity>(this TEntity entity, Guid? key = null) where TEntity : IEntity
        {
            entity.SetKey(key ?? Guid.NewGuid());
            return entity;
        }

        public static TPersistenceModel WithId<TPersistenceModel>(this TPersistenceModel entity, long id)
            where TPersistenceModel : IPersistenceModel
        {
            entity.SetId(id);
            return entity;
        }
    }
}