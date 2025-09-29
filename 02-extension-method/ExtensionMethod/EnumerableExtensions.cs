﻿using System.Numerics;

namespace ExtensionMethod
{
    public static class EnumerableExtensions
    {
        public static T MySum<T> (this IEnumerable<T> items) where T : INumber<T>
        {
            T sum = T.Zero;

            foreach (var item in items)
            {
                sum += item;
            }

            return sum;
        }

        public static ReturnType MySum<T, ReturnType>(this IEnumerable<T> items, Func<T, ReturnType> selector)
            where ReturnType : INumber<ReturnType>
        {
            ReturnType sum = ReturnType.Zero;

            foreach (var item in items)
            {
                sum += selector(item);
            }

            return sum;
        }

        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item)) yield return item;
            }
        }

        public static IEnumerable<T> MyOrderBy<T>(this IEnumerable<T> items)
            where T : IComparable<T>
        {
            var list = new List<T>(items);

            list.Sort((x, y) => x.CompareTo(y));

            foreach (var item in list)
                yield return item;
        }

        public static IEnumerable<T> MyOrderBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> keySelector)
            where TKey : IComparable<TKey>
        {
            var list = new List<T>(items);

            list.Sort((x, y) => keySelector(x).CompareTo(keySelector(y)));

            foreach (var item in list)
                yield return item;
        }
    }
}
