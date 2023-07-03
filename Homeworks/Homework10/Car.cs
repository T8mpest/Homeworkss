using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    abstract class Car
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }

        public abstract void Accelerate();
        public abstract void Brake();

        public virtual void GetSpeed()
        {
            Console.WriteLine($"The {Brand} car is currently running at {MaxSpeed} km/h.");
        }
    }

    class BMW : Car
    {
        public BMW()
        {
            Brand = "BMW";
            MaxSpeed = 200;
        }

        public override void Accelerate()
        {
            Console.WriteLine($"The {Brand} car is accelerating.");
            MaxSpeed += 10;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Brand} car is braking.");
            MaxSpeed -= 20;
        }
    }

    class Audi : Car
    {
        public Audi()
        {
            Brand = "Audi";
            MaxSpeed = 180;
        }

        public override void Accelerate()
        {
            Console.WriteLine($"The {Brand} car is accelerating.");
            MaxSpeed += 8;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Brand} car is braking.");
            MaxSpeed -= 16;
        }
    }
    class Mclaren : Car
    { 
     public Mclaren()
        {
            Brand = "Mclaren";
            MaxSpeed = 260;
        }
        public override void Accelerate()
        {
            Console.WriteLine($"The {Brand} car is accelerating.");
            MaxSpeed += 18;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Brand} car is braking.");
            MaxSpeed -= 30;
        }
    }
}


