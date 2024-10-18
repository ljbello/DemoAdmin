using System.Linq.Expressions;

namespace Rize.Admin.Data.Helpers
{
    public static class OrderByExtension
    {
        public static IQueryable<T> OrderByDynamic<T>(IQueryable<T> source, string sortColumn, string sortOrder)
        {
            var parameter = Expression.Parameter(typeof(T), "p");
            var property = Expression.Property(parameter, sortColumn);
            var lambda = Expression.Lambda(property, parameter);

            string methodName = sortOrder == "asc" ? "OrderBy" : "OrderByDescending";

            var resultExpression = Expression.Call(typeof(Queryable), methodName, new Type[] { typeof(T), property.Type }, source.Expression, Expression.Quote(lambda));
            return source.Provider.CreateQuery<T>(resultExpression);
        }

    }
}
