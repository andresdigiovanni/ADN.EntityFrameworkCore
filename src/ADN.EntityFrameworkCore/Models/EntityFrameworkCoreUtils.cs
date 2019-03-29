using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADN.EntityFrameworkCore
{
    /// <summary>
    /// A static class of methods for EntityFramework Core.
    /// </summary>
    public static class EntityFrameworkCoreUtils
    {
        /// <summary>
        /// Insert or update an element in a database.
        /// </summary>
        /// <typeparam name="T">The type of the element in the database.</typeparam>
        /// <param name="context">A DbContext instance.</param>
        /// <param name="model">Element to insert or update in the database.</param>
        public static void InsertOrUpdate<T>(this DbContext context, T model) where T : class
        {
            var entry = context.Entry(model);
            var primaryKey = entry.Metadata.FindPrimaryKey();

            if (primaryKey != null)
            {
                var keys = primaryKey.Properties
                    .Select(x => x.FieldInfo.GetValue(model))
                    .ToArray();

                var result = context.Find<T>(keys);
                if (result == null)
                {
                    context.Add(model);
                }
                else
                {
                    context.Entry(result).State = EntityState.Detached;
                    context.Update(model);
                }
            }
        }
    }
}
