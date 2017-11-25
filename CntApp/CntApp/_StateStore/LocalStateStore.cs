using CntApp._DB;
using CntApp._Files;
using Xamarin.Forms;

namespace CntApp._StateStore
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