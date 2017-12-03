using System;
using System.IO;
using CntApp.Droid.DependencyServices;
using CntApp.Utilities.Files;
using Xamarin.Forms;

[assembly: Dependency(typeof(FilePathResolver))]

namespace CntApp.Droid.DependencyServices
{
    public class FilePathResolver : FilePathResolverBase
    {
        public override string MyProfileImagePath => DefaultProfileImageFileName;

        public override string GetToolbarItemIconPath(string iconFileName)
        {
            var path = Compose("{0}", iconFileName);
            return path;
        }

        public override string GetSqliteDbFilePath(string dbFileName)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, dbFileName);
        }
    }
}