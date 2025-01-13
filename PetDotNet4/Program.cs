﻿using ClassLibrary1;
using System;

namespace PetDotNet4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Alice", Age = 30 };
            // Сериализация объекта в JSON
            string jsonString = SerializePattern.GetSerializationString(person);
            Console.WriteLine(jsonString);

            // Десериализация JSON обратно в объект
            var deserializedPerson = SerializePattern.Deserialize<Person>(jsonString);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadKey();
        }
    }
}