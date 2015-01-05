using Newtonsoft.Json;

namespace DurableTask
{
    /// <summary>
    /// Extension methods for the <see cref="JsonSerializerSettings"/> class which provide
    /// fluent API for overwriting selected properties.
    /// </summary>
    internal static class JsonSerializerSettingsExtensions
    {
        public static JsonSerializerSettings WithFormatting(this JsonSerializerSettings settings, Formatting formatting)
        {
            settings.Formatting = formatting;
            return settings;
        }

        public static JsonSerializerSettings WithTypeNameHandling(this JsonSerializerSettings settings, TypeNameHandling typeNameHandling)
        {
            settings.TypeNameHandling = typeNameHandling;
            return settings;
        }
    }
}
