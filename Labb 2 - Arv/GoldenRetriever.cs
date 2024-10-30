namespace Labb_2___Arv;

public class GoldenRetriever : Dog
{
    public string FavouriteToy { get; set; } = "Okänd favoritleksak";
    
    public GoldenRetriever(string name, int age, double weight, string sound, string type, int jumpHeight, string favouriteToy) : base(name, age, weight, sound, type, jumpHeight)
    {
        FavouriteToy = favouriteToy;
    }
    
    public GoldenRetriever() : base("Inget namn", 0, 0, "inget ljud", "Okänt", 10) {}

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Hundens favoritleksak är {FavouriteToy}");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} hämtar sin leksak {FavouriteToy}");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} skäller på dig för att du inte kastade leksaken!");
    }
}