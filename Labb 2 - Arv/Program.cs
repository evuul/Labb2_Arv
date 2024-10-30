namespace Labb_2___Arv;

class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog("Rex", 5, 10, "Voff!", "Hund", 50);
        var dog2 = new Dog(); // Default constructor
        dog.ShowInfo();
        dog.MakeSound();
        dog.jump();
        Console.WriteLine();
        dog2.ShowInfo();
        
        Console.WriteLine();
        var goldenRetriever = new GoldenRetriever("Stefan", 3, 15, "Voof", "Golden Retriever", 60, favouriteToy: "Boll");
        var goldenRetriever2 = new GoldenRetriever(); // Default constructor
        goldenRetriever.ShowInfo();
        goldenRetriever.Fetch();
        goldenRetriever.MakeSound();
        Console.WriteLine();
        goldenRetriever2.ShowInfo();
        
        Console.WriteLine();
        var bassetHound = new BassetHound("Boris", 4, 20, "vooooof", "Basset Hound", 30, colour: "Fauve");
        var bassetHound2 = new BassetHound(); // Default constructor
        bassetHound.ShowInfo();
        bassetHound.Sniff();
        bassetHound.MakeSound();
        Console.WriteLine();
        bassetHound2.ShowInfo();
        
        Console.WriteLine();
        var horse = new Horse("Black Stallion", 10, 500, "Gnägg", "Häst", 60);
        var horse2 = new Horse(); // Default constructor
        horse.ShowInfo();
        horse.MakeSound();
        horse.Run();
        Console.WriteLine();
        horse2.ShowInfo();

        Console.WriteLine();
        var bird = new Bird("Roger", 1, 0.5, "Tweet", "Fågel", true);
        var bird2 = new Bird(); // Default constructor
        bird.ShowInfo();
        bird.MakeSound();
        bird.Fly();
        Console.WriteLine();
        bird2.ShowInfo();
    }
}