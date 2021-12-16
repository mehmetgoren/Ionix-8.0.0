namespace Ionix.Data.Common
{
    using System;

    public sealed class CommandAdapter : CommandAdapterBase
    {
        private readonly Func<IEntityMetaDataProvider> providerMethod;

        public CommandAdapter(ICommandFactory factory, Func<IEntityMetaDataProvider> providerMethod)
            : base(factory)
        {
            if (null == providerMethod)
                throw new ArgumentNullException(nameof(providerMethod));

            this.providerMethod = providerMethod;
        }

        protected override IEntityMetaDataProvider CreateProvider()
        {
            return this.providerMethod();
        }
    }
}