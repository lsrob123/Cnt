namespace Lx.Utilities.NetStandard.Persistence
{
    public interface IPersistenceModel : IEntity
    {
        long Id { get; set; }

        void SetId(long id);
    }
}