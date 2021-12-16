namespace Ionix.Data.Migration.Common
{
    using System;
    using System.Collections.Generic;
    using Ionix.Data.Common;

    public interface IMigrationSqlQueryBuilder
    {
        SqlQuery CreateTable(IEnumerable<Type> types, DbSchemaMetaDataProvider provider,
            IColumnDbTypeResolver typeResolver);
    }
}