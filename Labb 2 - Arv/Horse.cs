namespace Labb_2___Arv;

public class Horse : Animal
{
    public int RunningSpeed { get; set; } = 20;
    
    public Horse(string name, int age, double weight, string sound, string type, int runningSpeed) : base(name, age, weight, sound, type)
    {
        RunningSpeed = runningSpeed;
    }
    
    public Horse() : base("Inget namn", 0, 0, "inget ljud", "Okänt") {}
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Hästens hastighet är {RunningSpeed}");
    }
    
    public void Run()
    {
        Console.WriteLine($"{Name} springer {RunningSpeed} km/h");
    }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} gnäggar högt!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} äter hö!");
    }
}