namespace CustomLINQExtMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(a => !predicate(a));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var list = collection.ToList();
            for (int i = 0; i < count - 1; i++)
            {
                list.AddRange(collection);
            }

            return list as IEnumerable<T>;
        }

        public static IEnumerable<string> WhereEndsWith(
            this IEnumerable<string> collection,
            IEnumerable<string> suffixes)
        {
            List<string> result = new List<string>();

            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        result.Add(item);
                    }
                }

            }

            return result as IEnumerable<string>;
        }
    }
}