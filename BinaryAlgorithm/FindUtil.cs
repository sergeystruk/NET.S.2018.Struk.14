using System;

namespace BinaryAlgorithm
{
    /// <summary>
    /// Provides static method for binary search
    /// </summary>
    public static class FindUtil
    {
        /// <summary>
        /// Binary search for sorted array
        /// </summary>
        /// <typeparam name="T">
        /// Type of elements in array
        /// </typeparam>
        /// <param name="array">
        /// Array for search
        /// </param>
        /// <param name="value">
        /// value to search
        /// </param>
        /// <returns>
        /// Index of element in array(or -1 if value doesn't exist in array)
        /// </returns>
        public static int BinarySearch<T>(T[] array, T value) where T:IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            return BinarySearch<T>(array, value, 0, array.Length - 1);
        }

        /// <summary>
        /// Logic for binary seach for sorted array
        /// </summary>
        /// <typeparam name="T">
        /// Type of elements in array
        /// </typeparam>
        /// <param name="array">
        /// Array for search
        /// </param>
        /// <param name="value">
        /// value to search
        /// </param>
        /// <param name="left">
        /// Left index of array to search
        /// </param>
        /// <param name="right">
        /// Right index of array to search
        /// </param>
        /// <returns>
        /// Index of element in array(or -1 if value doesn't exist in array)
        /// </returns>
        private static int BinarySearch<T>(T[] array, T value, int left, int right) where T : IComparable<T>
        {
            int mid = left + (right - left) / 2;

            if (left >= right)
            {
                return -1;
            }

            if (array[mid].CompareTo(value) == 0)
            {
                return mid;
            }

            if (array[mid].CompareTo(value) > 0)
            {
                return BinarySearch(array, value, left, mid);
            }

            return BinarySearch(array, value, mid + 1, right);
        }
    }
}
