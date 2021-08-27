namespace XBindConverterSimulation.Converters
{
    public static class BooleanConverter
    {
        /// <summary>
        ///    Convert any object into boolean value based on the null check.
        /// </summary>
        /// <returns>True if the parameter is not null, false otherwise.</returns>
        public static bool NotNullToTrue(object value)
        {
            return !(value is null);
        }
    }
}
