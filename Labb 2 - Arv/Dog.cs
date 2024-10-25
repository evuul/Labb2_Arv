namespace Labb_2___Arv;

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