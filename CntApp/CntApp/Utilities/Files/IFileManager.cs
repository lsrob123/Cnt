namespace CntApp.Utilities.Files
{
    public interface IFileManager
    {
        string MyProfileImagePath { get; }
        string GetToolbarItemIconPath(string iconFileName);
        string GetSqliteDbFilePath(string dbFileName);
    }
}