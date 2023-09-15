using System;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar person 1?");
            float person1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar person 2");
            float person2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar person3");
            float person3 = float.Parse(Console.ReadLine());

            float medellön = (person1 + person2 + person3) / 3;
            Console.WriteLine("Medellönen på företaget är " + medellön);

            Console.ReadKey();
        }
    }
}