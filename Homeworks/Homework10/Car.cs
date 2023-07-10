using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public interface IRadio
    {
        void TurnOn();
        void TurnOff();
        void ChangeStation(string station);
        void IncreaseVolume();
    }

    public interface ISeats
    {
        void AdjustPosition(string position);
        void HeatOn();
        void HeatOff();
    }
   
        public abstract class Vehicle
        {
            protected string Brand;
            protected int MaxSpeed;

            public abstract void Accelerate();
            public abstract void Brake();           
        }
    

    class BMW : Vehicle, ISeats, IRadio
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

        public void TurnOn()
        {
            Console.WriteLine($"The {Brand} car radio is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"The {Brand} car radio is turned off.");
        }

        public void ChangeStation(string station)
        {
            Console.WriteLine($"The {Brand} car radio station is changed to {station}.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine($"The {Brand} car radio volume is increased.");
        }

        public void AdjustPosition(string position)
        {
            Console.WriteLine($"The {Brand} car seats are adjusted to position {position}.");
        }

        public void HeatOn()
        {
            Console.WriteLine($"The {Brand} car seats heating is turned on.");
        }

        public void HeatOff()
        {
            Console.WriteLine($"The {Brand} car seats heating is turned off.");
        }
        public void PrintInterfaceComponents()
        {
            IRadio radio = this;
            ISeats seats = this;

            Console.WriteLine($"{Brand} Car Interface Components:");
            radio.TurnOn();
            radio.TurnOff();
            radio.ChangeStation("FM 101.5");
            radio.IncreaseVolume();
            seats.AdjustPosition("Position 1");
            seats.HeatOn();
            seats.HeatOff();
            Console.WriteLine();
        }
    }
    public class Audi : Vehicle, IRadio, ISeats
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
        public void TurnOn()
        {
            Console.WriteLine($"The {Brand} car radio is turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine($"The {Brand} car radio is turned off.");
        }
        public void ChangeStation(string station)
        {
            Console.WriteLine($"The {Brand} car radio station is changed to {station}.");
        }

            public void IncreaseVolume()
            {
                Console.WriteLine($"The {Brand} car radio volume is increased.");
            }

            public void AdjustPosition(string position)
            {
                Console.WriteLine($"The {Brand} car seats are adjusted to position {position}.");
            }

            public void HeatOn()
            {
                Console.WriteLine($"The {Brand} car seats heating is turned on.");
            }

            public void HeatOff()
            {
                Console.WriteLine($"The {Brand} car seats heating is turned off.");
            }
        public void PrintInterfaceComponents()
        {
            IRadio radio = this;
            ISeats seats = this;

            Console.WriteLine($"{Brand} Car Interface Components:");
            radio.TurnOn();
            radio.TurnOff();
            radio.ChangeStation("FM 101.5");
            radio.IncreaseVolume();
            seats.AdjustPosition("Position 1");
            seats.HeatOn();
            seats.HeatOff();
            Console.WriteLine();
        }
    }
        class Mclaren : Vehicle,IRadio, ISeats
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
            public void TurnOn()
           {
                Console.WriteLine($"The {Brand} car radio is turned on.");
           }

            public void TurnOff()
           {
                Console.WriteLine($"The {Brand} car radio is turned off.");
           }

            public void ChangeStation(string station)
           {
                Console.WriteLine($"The {Brand} car radio station is changed to {station}.");
           }

            public void IncreaseVolume()
           {
                Console.WriteLine($"The {Brand} car radio volume is increased.");
           }

            public void AdjustPosition(string position)
           {
                Console.WriteLine($"The {Brand} car seats are adjusted to position {position}.");
           }

            public void HeatOn()
           {
               Console.WriteLine($"The {Brand} car seats heating is turned on.");
           }

            public void HeatOff()
           {
               Console.WriteLine($"The {Brand} car seats heating is turned off.");
           }
            public void PrintInterfaceComponents()
           {
              IRadio radio = this;
              ISeats seats = this;

              Console.WriteLine($"{Brand} Car Interface Components:");
              radio.TurnOn();
              radio.TurnOff();
              radio.ChangeStation("FM 101.5");
              radio.IncreaseVolume();
              seats.AdjustPosition("Position 1");
              seats.HeatOn();
              seats.HeatOff();
              Console.WriteLine();
           }
    }
   
}
 



