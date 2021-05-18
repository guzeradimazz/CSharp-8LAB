using System;
using System.Threading;
namespace _8lab
{
    class Bear : AnimalClass, IAnimalAffairs
    {
        public Bear(int Strenght)
        {
            SleeppingHours = 0;

            this.Strenght = Strenght;

            Habitat = "All over the world";

            Nutrition = "Meat and green";

            MovementSpeed = 10;

            Color = color.Orange;

            SayHello SayHelloDelegate;

            if (DateTime.Now.Hour < 12)
                SayHelloDelegate = GoodMorning;

            else if (DateTime.Now.Hour > 12)
                SayHelloDelegate = GoodEvening;

            else
                throw new Exception("Error program");

            SayHelloDelegate();
        }

        public Bear()
        {
            SleeppingHours = 0;

            Strenght = 0;

            Habitat = "All over the world";

            Nutrition = "Meat and green";

            MovementSpeed = 10;

            Color = color.Orange;

            SayHello SayHelloDelegate;

            if (DateTime.Now.Hour < 12)
                SayHelloDelegate = GoodMorning;

            else if (DateTime.Now.Hour > 12)
                SayHelloDelegate = GoodEvening;

            else
                throw new Exception("Error program");

            SayHelloDelegate();
        }

        public bool SleepAllWinter = false;

        public int SleeppingHours { get; set; }

        private int Honey = 0, Strenght;

        private Guid id = Guid.NewGuid();

        public int GetMovementSpeed() => MovementSpeed;

        public string GetHabitat() => Habitat;

        public color GetColor() => Color;

        public void SleepDeep()
        {
            SleepAllWinter = true;
            Strenght += 10;
            SleeppingHours += 4;
            Console.WriteLine("Bear is sleep 10hours!!!\nBear is ready to big day!");
        }

        public void Sleep()
        {
            Strenght++;
        }

        public void FightWithBee()
        {
            if (Strenght == 0)
                Console.WriteLine("Bear is too tired(Simply call function sleep())");

            else if (Strenght > 0)
            {
                Console.WriteLine("Bear is fighting with bee's rigth now!!!");
                Console.WriteLine("Bear get some honey(+1)\nBut he is too tired");
                Honey++;
                Strenght = 0;
            }
            else
                throw new Exception("Error program");
        }

        public void PrintInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all Bear's : {Habitat}");
            Console.WriteLine($"Nutrition of all Bear's : {Nutrition}");
            Console.WriteLine($"MovementSpeed of all Bear's : {MovementSpeed}m/s");
            Console.WriteLine($"Color of all Bear's : {Color}");
            Console.WriteLine($"This Bear for all lifetime collect : {Honey} liters of honey");
            Console.WriteLine($"ID: {id}");
            if (SleepAllWinter)
                Console.WriteLine($"This Bear is sleep all winter!!! This Bear is hungry");
            Console.WriteLine("=========================================");
        }

        delegate void SayHello();

        public void GoodMorning()
        {
            Console.WriteLine("Good morning everybody!");
            FightWithBee();
            if (Strenght == 0)
                Console.WriteLine("I waiting nigth! I want some sleep");
        }

        public void GoodEvening()
        {
            Console.WriteLine("Good evening everybody!");
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine($"In {i} seconds I will go to sleep");
                Thread.Sleep(1000);
                if (i == 0)
                    SleepDeep();
            }
        }

        ~Bear() { }

    }
}
