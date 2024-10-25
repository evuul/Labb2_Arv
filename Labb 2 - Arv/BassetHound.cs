namespace Labb_2___Arv;

public class BassetHound : Dog
{
    public string Colour { get; set; }
    
    public BassetHound(string name, int age, double weight, string sound, string type, int jumpHeight, string colour) : base(name, age, weight, sound, type, jumpHeight)
    {
        Colour = colour;
    }
    
    public void Sniff()
    {
        Console.WriteLine($"{Name} is sniffing on the grass");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} Barks to signal it found something in the grass!");
    }
}