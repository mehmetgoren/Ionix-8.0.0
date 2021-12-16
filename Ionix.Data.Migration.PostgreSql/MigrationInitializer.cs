namespace Ionix.Data.Migration.PostgreSql
{
    using System;
    using Common;

    public class MigrationInitializer : MigrationInitializerBase
    {
        public MigrationInitializer()
        {
        }

        public MigrationInitializer(Action backup)
            : base(backup)
        {
        }

        protected override void RegisterMigrationServices()
        {
            Injector.RegisterSingleton<IMigrationService>(MigrationService.Instance);
        }
    }
}