using PetDotNet4;
using System.Text.Json;

namespace ClassLibrary1
{
    public class CoreSerializator<T> : ISerializer<T>
        where T : class
    {
        public string Serialize<T>(T person)
        {
            return JsonSerializer.Serialize(person);
        }

        public T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
