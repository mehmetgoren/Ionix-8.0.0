﻿namespace Ionix.Data.SqlServer
{
    using Common;
    using System;
    using Microsoft.Data.SqlClient;

    public class CommandFactory : CommandFactoryBase
    {
        public CommandFactory(IDbAccess dataAccess)
            : base(dataAccess)
        {
        }

        public override char ParameterPrefix => GlobalInternal.Prefix;

        public override IEntityCommandExecute CreateEntityCommand(EntityCommandType commandType)
        {
            switch (commandType)
            {
                case EntityCommandType.Update:
                    return new EntityCommandUpdate(base.DataAccess);
                case EntityCommandType.Insert:
                    return new EntityCommandInsert(base.DataAccess);
                case EntityCommandType.Upsert:
                    return new EntityCommandUpsert(base.DataAccess);
                case EntityCommandType.Delete:
                    return new EntityCommandDelete(base.DataAccess);
                default:
                    throw new NotSupportedException(commandType.ToString());
            }
        }

        public override IBatchCommandExecute CreateBatchCommand(EntityCommandType commandType)
        {
            switch (commandType)
            {
                case EntityCommandType.Update:
                    return new BatchCommandUpdate(base.DataAccess);
                case EntityCommandType.Insert:
                    return new BatchCommandInsert(base.DataAccess);
                case EntityCommandType.Upsert:
                    return new BatchCommandUpsert(base.DataAccess);
                case EntityCommandType.Delete:
                    return new BatchCommandDelete(base.DataAccess);
                default:
                    throw new NotSupportedException(commandType.ToString());
            }
        }

        public override IBulkCopyCommand CreateBulkCopyCommand()
        {
            DbAccess dbAccess = (DbAccess)base.DataAccess;
            SqlConnection sqlConnection = (SqlConnection)dbAccess.Connection;
            return new BulkCopyCommand(sqlConnection);
        }
    }
}