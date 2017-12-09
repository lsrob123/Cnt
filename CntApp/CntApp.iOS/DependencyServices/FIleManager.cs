using System;
using System.IO;
using CntApp.iOS.DependencyServices;
using CntApp.Utilities.Files;
using Xamarin.Forms;

[assembly: Dependency(typeof(FIleManager))]

namespace CntApp.iOS.DependencyServices {
    public class FIleManager : FilePathResolverBase {
        public override string MyProfileImagePath => $"myprofile/{DefaultProfileImageFileName}";

        public override void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        public override string ApplicationDataFolder =>
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public override string PersonalFolder =>
            Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public override string GetToolbarItemIconPath(string iconFileName) {
            var path = Compose("{0}", iconFileName);
            return path;
        }

        public override bool FileExists(string filePath) {
            return File.Exists(filePath);
        }
    }
}