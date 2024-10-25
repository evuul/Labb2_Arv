namespace Labb_2___Arv;

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

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating grass");
    }
}