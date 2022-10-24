
using System;

namespace MyBestProj.HomeWork
{
    public class Gun
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Clip { get; set; }
        public Gun()
        {
            Name = "gun";
            Weight = 3.5;
            Clip = 30;
        }
        public Gun(string name, double weight, int clip)
        {
            Name = name;
            Weight = weight;
            Clip = clip;
        }
        public override string ToString()
        {
            return $"Name:{Name} Weight:{Weight} Clip:{Clip}";
        }

        public static Gun CreateGun()
        {
            double weight = default;
            int clip = default;
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            bool endApp = false;
            while (!endApp)
            {
                Console.Write("Enter weight: ");
                endApp = double.TryParse(Console.ReadLine(), out weight);
            }
            endApp = false;
            while (!endApp)
            {
                Console.Write("Enter clip: ");
                endApp = int.TryParse(Console.ReadLine(), out clip);
            }
            Console.Clear();
            return new Gun(name, weight, clip);
        }
    }
}
