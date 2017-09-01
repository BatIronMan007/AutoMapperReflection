using System;
using System.Collections.Generic;

namespace AutoMapperCommon.Infrastructure
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable,
                Action<T> action)
        {
            foreach (T item in enumerable) { action(item); }
        }
    }

}
