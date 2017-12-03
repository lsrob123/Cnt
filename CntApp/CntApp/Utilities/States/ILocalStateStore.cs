using CntApp.Domains.MyProfile;

namespace CntApp.Utilities.States
{
    public interface ILocalStateStore
    {
        MyProfileViewModel MyProfileViewModel { get; }
    }
}