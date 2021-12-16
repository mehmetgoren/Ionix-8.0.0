namespace Ionix.Data.Common
{
    public interface IEntitySqlQueryBuilder
    {
        SqlQuery CreateQuery(object entity, IEntityMetaData metaData, int index); //Index ler batch ler için eklendi.
    }
}