using PetDotNet4;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClassLibrary1
{
    internal static class CoreSerializator
    {
        public static string Serialize(Person person)
        {
            return JsonSerializer.Serialize(person);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
