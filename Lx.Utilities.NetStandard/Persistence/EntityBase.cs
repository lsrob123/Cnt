using System;

namespace Lx.Utilities.NetStandard.Persistence
{
    public class EntityBase : IEntity
    {
        public Guid Key { get; protected set; }
        public virtual void SetKey(Guid key)
        {
            Key = key;
        }

    }
}