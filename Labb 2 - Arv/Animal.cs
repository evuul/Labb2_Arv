namespace Labb_2___Arv;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public string Sound { get; set; }
    public string Type { get; set; }
    
    public Animal(string name, int age, double weight, string sound, string type)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Sound = sound;
        Type = type;
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nWeight: {Weight}\nSound: {Sound}\nType: {Type}");
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} says {Sound}");
    }
    
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating something delicious");
    }
    
    public void Stare()
    {
        Console.WriteLine($"{Name} is staring at you with an intense look");
    }
}

public class Dog : Animal
{
    public int JumpHeight { get; set; }
    
    public Dog(string name, int age, double weight, string sound, string type, int jumpHeight) : base(name, age, weight, sound, type)
    {
        JumpHeight = jumpHeight;
    }
    
    public void jump()
    {
        Console.WriteLine($"{Name} jumps {JumpHeight} cm high");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} Barks loud!");
    }
}

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

public class Horse : Animal
{
    public int RunningSpeed { get; set; }
    
    public Horse(string name, int age, double weight, string sound, string type, int runningSpeed) : base(name, age, weight, sound, type)
    {
        RunningSpeed = runningSpeed;
    }
    
    public void Run()
    {
        Console.WriteLine($"{Name} runs {RunningSpeed} km/h");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} Neighs loud!");
    }
}

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
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes a clapping sound with its wings while flying away");
    }
}