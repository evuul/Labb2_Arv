namespace Labb_2___Arv;

class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog("Doggo", 5, 10, "Bark", "Dog", 50);
        dog.ShowInfo();
        dog.MakeSound();

        
        Console.WriteLine();
        
        var GoldenRetriever = new GoldenRetriever("Golden", 3, 15, "Bark", "Golden Retriever", 60, favouriteToy: "Ball");
        GoldenRetriever.ShowInfo();
        GoldenRetriever.Fetch();
        GoldenRetriever.MakeSound();

        
        Console.WriteLine();
        
        var BassetHound = new BassetHound("Basset", 4, 20, "Bark", "Basset Hound", 30, colour: "Fauve");
        BassetHound.ShowInfo();
        BassetHound.MakeSound();
        BassetHound.Sniff();
        
        Console.WriteLine();
        
        var Horse = new Horse("Horse", 10, 500, "Neigh", "Horse", 60);
        Horse.ShowInfo();
        Horse.MakeSound();
        Horse.Run();
        
        Console.WriteLine();

        var Bird = new Bird("Bird", 1, 0.5, "Tweet", "Bird", true);
        Bird.ShowInfo();
        Bird.MakeSound();
        Bird.Fly();

    }
}