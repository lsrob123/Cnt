using System.IO;

namespace CntApp.Utilities.Files {
    public abstract class FilePathResolverBase : IFileManager {
        public const string DefaultProfileImageFileName = "myprofile.jpg";
        public virtual string RootFolderName => "cnt";
        public abstract string MyProfileImagePath { get; }
        public abstract string GetToolbarItemIconPath(string iconFileName);
        public abstract bool FileExists(string filePath);
        public abstract string ApplicationDataFolder { get; }
        public abstract string PersonalFolder { get; }

        public virtual string GetSqliteDbFilePath(string dbFileName) {
            return Path.Combine(ApplicationDataFolder, RootFolderName, dbFileName);
        }

        /// <summary>
        ///     Using string.Format(pattern, fileName) to compose the file path
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="fileName"></param>
        /// <returns>string.Format(pattern, fileName)</returns>
        protected string Compose(string pattern, string fileName) {
            return string.Format(pattern, fileName);
        }
    }
}