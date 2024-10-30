namespace Labb_2___Arv;

public class Bird : Animal
{
    public bool CanFly { get; set; } = true;
    
    public Bird(string name, int age, double weight, string sound, string type, bool canFly) : base(name, age, weight, sound, type)
    {
        CanFly = canFly;
    }
    
    public Bird() : base("Inget namn", 0, 0, "inget ljud", "Okänt") {}
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        if (CanFly)
        {
            Console.WriteLine($"{Name} flyger iväg");
        }
        else
        {
            Console.WriteLine($"{Name} kan inte flyga");
        }
    }
    
    public void Fly()
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} flyger iväg");
        }
        else
        {
            Console.WriteLine($"{Name} kan inet flyga");
        }
    }
    public override void Stare()
    {
        Console.WriteLine($"{Name} stirrar på dig med sina ögon");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} gör ett lätt ljud med vingarna medans den flyger iväg");
    }
}