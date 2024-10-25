namespace Labb_2___Arv;

public class GoldenRetriever : Dog
{
    public string FavouriteToy { get; set; }
    
    public GoldenRetriever(string name, int age, double weight, string sound, string type, int jumpHeight, string favouriteToy) : base(name, age, weight, sound, type, jumpHeight)
    {
        FavouriteToy = favouriteToy;
    }
    
    public void Fetch()
    {
        Console.WriteLine($"{Name} fetches the {FavouriteToy}");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} Barks for you to throw its toy!");
    }
}