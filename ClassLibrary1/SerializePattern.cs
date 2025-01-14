using PetDotNet4;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class SerializePattern<T>
        where T : class
    {
        public Serializator<T> Serializator { get; set; }

        public SerializePattern()
        {
            Serializator = new Serializator<T>();
#if NET48_OR_GREATER
                Serializator.Serializer = new FrameworkSerializator<T>();
#elif NET8_0_OR_GREATER
                Serializator.Serializer = new CoreSerializator<T>();
#endif
        }

        public T Deserialize<T>(string json)
        {
            return Serializator.Deserialize<T>(json);
        }

        public string Serialize(T person)
        {
            return Serializator.Serialize(person);
        }
    }
}
