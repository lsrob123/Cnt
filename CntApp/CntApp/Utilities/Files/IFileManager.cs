namespace CntApp.Utilities.Files
{
    public interface IFileManager
    {
        string RootFolderName { get; }
        string MyProfileImagePath { get; }
        string GetToolbarItemIconPath(string iconFileName);
        string GetSqliteDbFilePath(string dbFileName);
        bool FileExists(string filePath);
        string ApplicationDataFolder { get; }
        string PersonalFolder { get; }
    }
}