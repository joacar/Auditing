using System;
using Audit.Abstractions;

namespace Audit
{
    /// <summary>
    /// Obfuscator for Swedish Personal Identificitation Number (personnummer).
    /// </summary>
    public class PinObfuscator : IObfuscator
    {
        /// <summary>
        /// Obfuscate the Swedish PIN <paramref name="value"/>.
        /// </summary>
        /// <returns>The obfuscate.</returns>
        /// <param name="value">Value.</param>
        public string Obfuscate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            // Swedish personal identification number has several formats:
            // yyyyMMdd-XXXX (13)
            // yyMMdd-XXXX (11)
            // yyyyMMddXXXX (12)
            // yyMMddXXXX (10)
            // What we will do is to obfuscate the last four digits.
            // This will be somewhat format agnostic.
            var length = value.Length;
            if (length < 10 || length > 13)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Invalid Swedish PIN");
            }
            return value.Substring(0, length - 4) + "****";
        }
    }
}
