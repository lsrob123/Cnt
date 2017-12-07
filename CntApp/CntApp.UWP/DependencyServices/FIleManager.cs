using System;
using System.IO;
using CntApp.Utilities.Files;
using CntApp.UWP.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(FIleManager))]

namespace CntApp.UWP.DependencyServices {
    public class FIleManager : FilePathResolverBase {
        public override string MyProfileImagePath => Compose(@"/Assets/MyProfile/{0}", DefaultProfileImageFileName);

        public override string ApplicationDataFolder =>
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public override string PersonalFolder =>
            Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public override string GetToolbarItemIconPath(string iconFileName) {
            return Compose(@"/Assets/ToobarItemIcons/{0}", iconFileName);
        }

        public override bool FileExists(string filePath) {
            return File.Exists(filePath);
        }
    }
}