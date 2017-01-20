namespace NullObjectsPattern.Common
{
    using System;
    using System.Collections.Generic;

    internal static class EnumerableExtensions
    {
        public static void Do<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
            {
                action(item);
            }
        }
    }
}
