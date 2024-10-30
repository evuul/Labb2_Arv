namespace Labb_2___Arv;

    public class Dog : Animal
    {
        public int JumpHeight { get; set; } = 10;
    
        public Dog(string name, int age, double weight, string sound, string type, int jumpHeight) : base(name, age, weight, sound, type)
        {
            JumpHeight = jumpHeight;
        }
        
        public Dog() : base("Inget namn", 0, 0, "inget ljud", "Okänt") {}

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Hundens hopp höjd är {JumpHeight}");
        }

        public void jump()
        {
            Console.WriteLine($"{Name} hoppar {JumpHeight} cm högt");
        }
    
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller högt!");
        }
    }