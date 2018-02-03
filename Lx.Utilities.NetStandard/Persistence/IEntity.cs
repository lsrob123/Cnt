using System;

namespace Lx.Utilities.NetStandard.Persistence
{
    public interface IEntity
    {
        Guid Key { get; }

        void SetKey(Guid key);
    }
}