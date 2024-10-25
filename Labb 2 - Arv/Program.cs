namespace Labb_2___Arv;

class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog("Rex", 5, 10, "Bark", "Dog", 50);
        dog.ShowInfo();
        dog.MakeSound();
        dog.jump();
        
        Console.WriteLine();
        
        var goldenRetriever = new GoldenRetriever("Stefan", 3, 15, "Bark", "Golden Retriever", 60, favouriteToy: "Ball");
        goldenRetriever.ShowInfo();
        goldenRetriever.Fetch();
        goldenRetriever.MakeSound();
        
        Console.WriteLine();
        
        var bassetHound = new BassetHound("Boris", 4, 20, "Bark", "Basset Hound", 30, colour: "Fauve");
        bassetHound.ShowInfo();
        bassetHound.Sniff();
        bassetHound.MakeSound();
        
        Console.WriteLine();
        
        var horse = new Horse("Black Stallion", 10, 500, "Neigh", "Horse", 60);
        horse.ShowInfo();
        horse.MakeSound();
        horse.Run();
        
        Console.WriteLine();

        var bird = new Bird("Bird", 1, 0.5, "Tweet", "Bird", true);
        bird.ShowInfo();
        bird.MakeSound();
        bird.Fly();

    }
}