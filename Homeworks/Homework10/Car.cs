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
        void IncreaseVolume(string volume);
    }

    public interface ISeats
    {
        void AdjustPosition(string position);
        void HeatOn();
        void HeatOff();
    }

    public abstract class Vehicle
    {
        protected string Brand { get; set; }
        protected int CurrentSpeed { get; set; }
        protected int MaxSpeed { get; set; }
        public bool IsMovingForward { get; set; }


        public abstract void Accelerate(int amount);
        public abstract void Brake(int amount);
        public abstract void GetSpeed();
        public Vehicle(string brand, int maxSpeed)
        {
            Brand = brand;
            CurrentSpeed = 0;
            MaxSpeed = maxSpeed;
        }
    }


    class BMW : Vehicle, ISeats, IRadio
    {
        public BMW() : base("BMW", 250)
        {
            CurrentSpeed = 200;
        }
        public override void GetSpeed()
        {
            Console.WriteLine($"{Brand} speed: {CurrentSpeed}/{MaxSpeed}");
        }

        public override void Accelerate(int amount)
        {
            Console.WriteLine($"The {Brand} car is accelerating.");
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException("amount", "Acceleration amount should be a positive value.");

                int newSpeed = CurrentSpeed + amount;
                if (newSpeed > MaxSpeed)
                {
                    Console.WriteLine($"Error: Exceeding maximum speed of {MaxSpeed}.");
                    return;
                }

                CurrentSpeed = newSpeed;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public override void Brake(int amount)
        {
            Console.WriteLine($"The {Brand} car is braking.");
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException("amount", "Braking amount should be a positive value.");

                int newSpeed = CurrentSpeed - amount;
                if (newSpeed < 0)
                {
                    Console.WriteLine($"Error: Car cannot move in reverse at this speed.");
                    return;
                }

                CurrentSpeed = newSpeed;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
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

        public void IncreaseVolume(string volume)
        {
            Console.WriteLine($"The {Brand} car radio volume is increased for {volume}.");
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
            radio.IncreaseVolume("10%");
            seats.AdjustPosition("Position 1");
            seats.HeatOn();
            seats.HeatOff();
            Console.WriteLine();
        }
    }
    public class Audi : Vehicle, IRadio, ISeats
    {
        public Audi() : base("Audi", 200)
        {
            CurrentSpeed = 180;
        }
        public override void GetSpeed()
        {
            Console.WriteLine($"{Brand} speed: {CurrentSpeed}/{MaxSpeed}");
        }
        public override void Accelerate(int amount)
        {
            Console.WriteLine($"The {Brand} car is accelerating.");
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException("amount", "Acceleration amount should be a positive value.");

                int newSpeed = CurrentSpeed + amount;
                if (newSpeed > MaxSpeed)
                {
                    Console.WriteLine($"Error: Exceeding maximum speed of {MaxSpeed}.");
                    newSpeed = MaxSpeed;
                }

                CurrentSpeed = newSpeed;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
        public override void Brake(int amount)
        {
            Console.WriteLine($"The {Brand} car is braking.");
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException("amount", "Braking amount should be a positive value.");

                int newSpeed = CurrentSpeed - amount;
                if (newSpeed < 0)
                {
                    Console.WriteLine($"Error: Car cannot move in reverse at this speed.");
                    newSpeed = MaxSpeed;
                }

                CurrentSpeed = newSpeed;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
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

        public void IncreaseVolume(string volume)
        {
            Console.WriteLine($"The {Brand} car radio volume is increased for {volume}.");
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
            radio.ChangeStation("FM 103.2");
            radio.IncreaseVolume("20%");
            seats.AdjustPosition("Position 3");
            seats.HeatOn();
            seats.HeatOff();
            Console.WriteLine();
        }
    }
    class Mclaren : Vehicle, IRadio, ISeats
    {
        public Mclaren() : base("Mclaren", 278)
        {
            CurrentSpeed = 260;
        }

        public override void GetSpeed()
        {
            Console.WriteLine($"{Brand} speed: {CurrentSpeed}/{MaxSpeed}");
        }

        public override void Accelerate(int amount)
        {
            Console.WriteLine($"The {Brand} car is accelerating.");
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException("amount", "Acceleration amount should be a positive value.");

                int newSpeed = CurrentSpeed + amount;
                if (newSpeed > MaxSpeed)
                {
                    Console.WriteLine($"Error: Exceeding maximum speed of {MaxSpeed}.");
                    newSpeed = MaxSpeed;
                }

                CurrentSpeed = newSpeed;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public override void Brake(int amount)
        {
            Console.WriteLine($"The {Brand} car is braking.");
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException("amount", "Braking amount should be a positive value.");

                int newSpeed = CurrentSpeed - amount;
                if (newSpeed < 0)
                {
                    Console.WriteLine($"Error: Car cannot move in reverse at this speed.");
                    return;
                }

                CurrentSpeed = newSpeed;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
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

        public void IncreaseVolume(string volume)
        {
            Console.WriteLine($"The {Brand} car radio volume is increased for {volume}.");
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
            radio.IncreaseVolume("40%");
            seats.AdjustPosition("Position 1");
            seats.HeatOn();
            seats.HeatOff();
            Console.WriteLine();
        }
    }

}




