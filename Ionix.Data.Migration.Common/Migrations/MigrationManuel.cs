﻿namespace Ionix.Data.Migration.Common
{
    public abstract class MigrationManuel : Migration
    {
        protected MigrationManuel(MigrationVersion version)
            : base(version)
        {
        }

        public sealed override bool IsBuiltIn => false;
    }
}