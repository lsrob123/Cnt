using System.IO;
using Windows.Storage;
using CntApp.UWP.DependencyServices;
using CntApp._Files;
using Xamarin.Forms;

[assembly: Dependency(typeof(FilePathResolver))]

namespace CntApp.UWP.DependencyServices
{
    public class FilePathResolver : FilePathResolverBase
    {
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