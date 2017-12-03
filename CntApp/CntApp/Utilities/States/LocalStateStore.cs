using CntApp.Domains.MyProfile;
using CntApp.Utilities.DB;
using CntApp.Utilities.Dependencies;

namespace CntApp.Utilities.States
{
    public class LocalStateStore : ILocalStateStore
    {
        private readonly ILocalDb _localDb;

        public LocalStateStore()
        {
            _localDb = DependencyRegistry.LocalDb;
            MyProfileViewModel = DependencyRegistry.MyProfileViewModel;
        }

        public MyProfileViewModel MyProfileViewModel { get; protected set; }
    }
}