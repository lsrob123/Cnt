using System.IO;
using CntApp.Utilities.Files;
using CntApp.UWP.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(FIleManager))]

namespace CntApp.UWP.DependencyServices
{
    public class FIleManager : FilePathResolverBase
    {
        public override string MyProfileImagePath => Compose(@"/Assets/MyProfile/{0}", DefaultProfileImageFileName);

        public override string GetToolbarItemIconPath(string iconFileName)
        {
            //return ApplicationData.Current.LocalFolder.Path.TrimEnd('/') +
            //       Compose("/Assets/ToobarItemIcons/{0}", iconFileName);
            return Compose(@"/Assets/ToobarItemIcons/{0}", iconFileName);
        }

        public override string GetSqliteDbFilePath(string dbFileName)
        {
            //return Path.Combine(ApplicationData.Current.LocalFolder.Path, dbFileName);
            return Path.Combine("/DBs/{0}", dbFileName);
        }
    }
}