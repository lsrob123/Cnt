using CntApp.Utilities.Files;
using CntApp.UWP.DependencyServices;
using System;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileManager))]

namespace CntApp.UWP.DependencyServices
{
    public class FileManager : FileManagerBase {
        public override string MyProfileImagePath => Compose(@"/Assets/MyProfile/{0}", DefaultProfileImageFileName);

        public override void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        //public override string ApplicationDataFolder =>
        //    Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public override string ApplicationDataFolder =>
            ApplicationData.Current.LocalFolder.Path;

        public override string PersonalFolder =>
            ApplicationData.Current.LocalFolder.Path;

        public override string GetToolbarItemIconPath(string iconFileName) {
            return Compose(@"/Assets/ToobarItemIcons/{0}", iconFileName);
        }

        public override bool FileExists(string filePath) {
            return File.Exists(filePath);
        }
    }
}