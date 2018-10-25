namespace Audit.Abstractions
{
    /// <summary>
    /// Obfuscator to obfuscate sensitive data.
    /// </summary>
    public interface IObfuscator
    {

        /// <summary>
        /// Obfuscate the specified value.
        /// </summary>
        /// <returns>The obfuscated value.</returns>
        /// <param name="value">Value to obfuscate.</param>
        string Obfuscate(string value);
    }
}
