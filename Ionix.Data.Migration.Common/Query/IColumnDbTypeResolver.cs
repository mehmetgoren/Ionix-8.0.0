namespace Ionix.Data.Migration.Common
{
    using Ionix.Data.Common;

    public interface IColumnDbTypeResolver
    {
        Column GetColumn(PropertyMetaData metaData);
    }
}