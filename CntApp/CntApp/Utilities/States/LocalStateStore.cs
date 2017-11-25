using CntApp.Utilities.DB;

namespace CntApp.Utilities.States
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