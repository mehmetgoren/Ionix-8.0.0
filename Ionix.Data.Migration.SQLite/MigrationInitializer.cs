namespace Ionix.Data.Migration.SQLite
{
    using System;
    using Common;

    public class MigrationInitializer : MigrationInitializerBase
    {
        public MigrationInitializer()
        {
            this.CheckTransactionalDbAccess = false;
        }

        public MigrationInitializer(Action backup)
            : base(backup)
        {
            this.CheckTransactionalDbAccess = false;
        }

        protected override void RegisterMigrationServices()
        {
            Injector.RegisterSingleton<IMigrationService>(MigrationService.Instance);
        }
    }
}