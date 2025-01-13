
using System;

namespace ClassLibrary1
{
    public class Serializator<T> where T : class
    {
        private ISerializer<T> _serializer;
        public ISerializer<T> Serializer
        {
            set { _serializer = value; }
        }

        public string Serialize(T serializeElement)
        {
            return _serializer.Serialize(serializeElement);
        }

        public T Deserialize<T>(string serializedElement)
        {
            return _serializer.Deserialize<T>(serializedElement);
        }
    }
}
