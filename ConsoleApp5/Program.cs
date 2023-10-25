using System.Threading.Channels;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);

            foreach (Animal a in animals) 
            {
                a.Sound();
            }
        }
    }


    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Hej");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat is saying Mjauuuu mjau");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog is saying vooff vooff");
        }
    }
}