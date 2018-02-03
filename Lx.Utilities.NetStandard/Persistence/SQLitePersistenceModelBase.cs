using SQLite;

namespace Lx.Utilities.NetStandard.Persistence
{
    public abstract class SqLitePersistenceModelBase : EntityBase, IPersistenceModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public long Id { get; set; }

        public virtual void SetId(long id)
        {
            Id = id;
        }
    }
}