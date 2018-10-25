using System;
using Audit.Abstractions;

namespace Audit
{

    /// <summary>
    /// Email obfuscator.
    /// </summary>
    public class EmailObfuscator : IObfuscator
    {
        /// <summary>
        /// Obfuscate the specified email.
        /// </summary>
        /// <returns>The obfuscated email.</returns>
        /// <param name="value">Value.</param>
        public string Obfuscate(string value)
        {

            if (value == null)
            {
                throw new ArgumentNullException(value);
            }
            var indexOfSeparator = value.IndexOf("@", StringComparison.Ordinal);
            if (indexOfSeparator < 0)
            {
                return "*".Repeat(value.Length);
            }
            var domain = value.Substring(indexOfSeparator);
            // Extract the name without domain.
            var name = value.Substring(0, indexOfSeparator);
            // Retain the first and last character.
            var obfuscateLength = name.Length - 2;
            return $"{name[0]}" +
                $"{"*".Repeat(obfuscateLength)}" +
                $"{name[name.Length - 1]}" +
                $"{domain}";
        }
    }
}
