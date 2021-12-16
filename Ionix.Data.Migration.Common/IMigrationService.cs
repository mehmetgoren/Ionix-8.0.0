namespace Ionix.Data.Migration.Common
{
    using System.Collections.Generic;
    using Ionix.Data.Common;

    public interface IMigrationService
    {
        IMigrationSqlQueryBuilder MigrationSqlQueryBuilder { get; }

        IColumnDbTypeResolver ColumnDbTypeResolver { get; }

        bool IsDatabaseVersionTableCreated(ICommandAdapter cmd);
        IEnumerable<DatabaseVersionBase> GetDatabaseVersionList(ICommandAdapter cmd);
        DatabaseVersionBase GetLastDatabaseVersion(ICommandAdapter cmd);


        DatabaseVersionBase CreateDatabaseVersion();
    }
}