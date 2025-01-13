﻿using ClassLibrary1;
using PetDotNet4;

var person = new Person { Name = "Alice", Age = 30 };
// Сериализация объекта в JSON
var serializer = new SerializePattern<Person>();
string jsonString = serializer.Serialize(person);
Console.WriteLine(jsonString);

// Десериализация JSON обратно в объект
var deserializedPerson = serializer.Deserialize<Person>(jsonString);
Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
Console.ReadKey();