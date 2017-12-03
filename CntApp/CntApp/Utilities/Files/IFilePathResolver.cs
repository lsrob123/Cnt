namespace CntApp.Utilities.Files
{
    public interface IFilePathResolver
    {
        string MyProfileImagePath { get; }
        string GetToolbarItemIconPath(string iconFileName);
        string GetSqliteDbFilePath(string dbFileName);
    }
}