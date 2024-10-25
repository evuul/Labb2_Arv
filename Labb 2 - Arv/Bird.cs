namespace Labb_2___Arv;

public class Bird : Animal
{
    public bool CanFly { get; set; }
    
    public Bird(string name, int age, double weight, string sound, string type, bool canFly) : base(name, age, weight, sound, type)
    {
        CanFly = canFly;
    }
    
    public void Fly()
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} is flying");
        }
        else
        {
            Console.WriteLine($"{Name} can't fly");
        }
    }
    public override void Stare()
    {
        Console.WriteLine($"{Name} is staring at you");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes a clapping sound with its wings while flying away");
    }
}