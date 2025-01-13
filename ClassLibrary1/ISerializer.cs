using PetDotNet4;
namespace ClassLibrary1
{
    public interface ISerializer<T>
        where T : class
    {
        string Serialize<T>(T person);

        T Deserialize<T>(string json);
    }
}
