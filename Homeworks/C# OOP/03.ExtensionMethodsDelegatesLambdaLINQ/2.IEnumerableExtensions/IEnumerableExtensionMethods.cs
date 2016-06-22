namespace _2.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct
        {
            T sum = default(T);
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            T product = (dynamic)1;
            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct, IComparable
        {
            T min = collection.FirstOrDefault();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : struct, IComparable
        {
            T max = default(T);
            {
                foreach (var item in collection)
                {
                    if (item.CompareTo(max) > 0)
                    {
                        max = item;
                    }
                }
            }

            return max;
        }

        public static double Avg<T>(this IEnumerable<T> collection) where T : struct
        {
            return (dynamic)collection.Sum() / (double)collection.Count();
        }
    }
}
