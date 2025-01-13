using Newtonsoft.Json;

namespace ClassLibrary1
{
    internal class FrameworkSerializator<T> : ISerializer<T> where T : class
    {
        public string Serialize<T>(T person)
        {
            return JsonConvert.SerializeObject(person);
        }

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
