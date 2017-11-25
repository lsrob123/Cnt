﻿using CntApp._Files;
using SQLite;

namespace CntApp._DB
{
    public class LocalDb : ILocalDb
    {
        private readonly SQLiteAsyncConnection _db;

        public LocalDb(IFilePathResolver filePathResolver)
        {
            var dbFilePath = filePathResolver.GetSqliteDbFilePath(nameof(LocalDb));
            _db = new SQLiteAsyncConnection(dbFilePath);
        }
    }
}