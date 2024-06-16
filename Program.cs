using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Ism_Familya");
        string[] names = {"Matrasulov.J","Kalandarov.S","Abdusamatov.J","Abdusamatov.I"};
        foreach(string i in names)
        {
            Console.Write(i + "-");
            Console.WriteLine(i + ":" + Console.ReadLine() + " ball" );
        }
        // static void New (string message)
        // {
        //     Console.WriteLine(message);
        // }
        
    }
}