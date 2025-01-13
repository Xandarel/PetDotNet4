using PetDotNet4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassLibrary1
{
    public static class SerializePattern
    {
        public static string GetSerializationString(Person person)
        {
            if (RuntimeInformation.FrameworkDescription.StartsWith(".NET Framework"))
            {
                return FrameworkSerializator.Serialize(person);
            }
            else
            {
                return CoreSerializator.Serialize(person);
            }

        }

        public static T Deserialize<T>(string json)
        {
            if (RuntimeInformation.FrameworkDescription.StartsWith(".NET Framework"))
            {
                return FrameworkSerializator.Deserialize<T>(json);
            }
            else
            {
                return CoreSerializator.Deserialize<T>(json);
            }
        }
    }
}
