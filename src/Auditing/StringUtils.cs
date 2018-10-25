using System;

namespace Audit
{
    public static class StringUtils
    {
        /// <summary>
        /// Repeat the first character in <paramref name="value"/> <paramref name="count"/> times..
        /// </summary>
        /// <returns>The repeat.</returns>
        /// <param name="value">Value to repeat.</param>
        /// <param name="count">Number of times to repeat.</param>
        public static string Repeat(this string value, int count)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Must be a positive integer");
            }
            return new string(value[0], count);
        }
    }
}
