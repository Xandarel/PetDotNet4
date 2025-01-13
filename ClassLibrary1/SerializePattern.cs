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
            if (RuntimeInformation.FrameworkDescription.StartsWith(".NET Framework"))
            {
                Serializator.Serializer = new FrameworkSerializator<T>();
            }
            else
            {
                Serializator.Serializer = new CoreSerializator<T>();
            }
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
