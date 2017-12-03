using System;
using System.IO;
using CntApp.iOS.DependencyServices;
using CntApp.Utilities.Files;
using Xamarin.Forms;

[assembly: Dependency(typeof(FilePathResolver))]

namespace CntApp.iOS.DependencyServices
{
    public class FilePathResolver : FilePathResolverBase
    {
        public override string MyProfileImagePath => $"myprofile/{DefaultProfileImageFileName}";

        public override string GetToolbarItemIconPath(string iconFileName)
        {
            var path = Compose("{0}", iconFileName);
            return path;
        }

        public override string GetSqliteDbFilePath(string dbFileName)
        {
            var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
                Directory.CreateDirectory(libFolder);

            return Path.Combine(libFolder, dbFileName);
        }
    }
}