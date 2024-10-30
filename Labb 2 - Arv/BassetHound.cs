namespace Labb_2___Arv;

public class BassetHound : Dog
{
    public string Colour { get; set; } = "Okänd färg";
    
    public BassetHound(string name, int age, double weight, string sound, string type, int jumpHeight, string colour) : base(name, age, weight, sound, type, jumpHeight)
    {
        Colour = colour;
    }
    
    public BassetHound() : base("Inget namn", 0, 0, "inget ljud", "Okänt", 10) {}

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Hundens färg är  {Colour}");
    }
    
    public void Sniff()
    {
        Console.WriteLine($"{Name} luktar på gräset");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} skäller för att signalera att det är något i gräset!");
    }
}