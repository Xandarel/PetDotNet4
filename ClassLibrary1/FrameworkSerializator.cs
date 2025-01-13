using Newtonsoft.Json;
using PetDotNet4;

namespace ClassLibrary1
{
    internal static class FrameworkSerializator
    {
        public static string Serialize(Person person)
        {
            return JsonConvert.SerializeObject(person);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
