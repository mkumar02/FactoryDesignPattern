using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Factory Design Pattern example");

            AnimalFactory factory = new AnimalFactory();

            Console.WriteLine("Enter 1 to hear voice of Dog and 2 to hear voice of Cat");
            int val = Convert.ToInt32(Console.ReadLine());
            IAnimal animal = factory.CreateAnimal(val);
            Console.WriteLine(animal.Sound());
        }
    }
}
