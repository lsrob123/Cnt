using CntApp.Utilities.DB;

namespace CntApp.Utilities.StateStore
{
    public class LocalStateStore : ILocalStateStore
    {
        private readonly  ILocalDb _localDb;

        public LocalStateStore(ILocalDb localDb)
        {
            _localDb = localDb;
        }
    }
}