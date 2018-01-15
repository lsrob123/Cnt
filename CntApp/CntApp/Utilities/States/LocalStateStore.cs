using CntApp.Domains.MyProfile;
using CntApp.Utilities.Dependencies;

namespace CntApp.Utilities.States
{
    public class LocalStateStore : ILocalStateStore
    {
        public LocalStateStore()
        {
            MyProfileViewModel = DependencyRegistry.MyProfileViewModel;
        }

        public MyProfileViewModel MyProfileViewModel { get; protected set; }
    }
}