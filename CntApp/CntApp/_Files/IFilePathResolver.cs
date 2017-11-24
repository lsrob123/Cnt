﻿namespace CntApp._Files
{
    public interface IFilePathResolver
    {
        string GetToolbarItemIconPath(string iconFileName);
        string GetSqliteDbFilePath(string dbFileName);
    }
}