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
        Type = type;
        Name = name;
        Age = age;
        Weight = weight;
        Sound = sound;
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nWeight: {Weight}\nSound: {Sound}\nType: {Type}");
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} says {Sound}");
    }
    
    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating something delicious");
    }
    
    public virtual void Stare()
    {
        Console.WriteLine($"{Name} is staring at you with an intense look");
    }
}