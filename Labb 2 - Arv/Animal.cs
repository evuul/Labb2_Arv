namespace Labb_2___Arv;

public class Animal
{
    public string Name { get; set; } = "Inget namn";
    public int Age { get; set; } = 0;
    public double Weight { get; set; } = 0;
    public string Sound { get; set; } = "Inget ljud";
    public string Type { get; set; } = "Okänt";
    
    public Animal(string name, int age, double weight, string sound, string type)
    {
        Type = type;
        Name = name;
        Age = age;
        Weight = weight;
        Sound = sound;
    }
    
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nWeight: {Weight}\nSound: {Sound}\nType: {Type}");
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} says {Sound}");
    }
    
    public virtual void Eat()
    {
        Console.WriteLine($"{Name} äter något gott");
    }
    
    public virtual void Stare()
    {
        Console.WriteLine($"{Name} tittar på dig med sina ögon");
    }
}