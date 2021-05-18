using System;
namespace _8lab
{
    class Worm : AnimalClass, ICloneable<Worm>
    {
        public Worm()
        {
            IsHungry = true;
            Habitat = "Earth";
            Nutrition = "Minerals";
            MovementSpeed = 1;
            Color = color.Red;
        }

        public Worm(bool IsHungry)
        {
            this.IsHungry = IsHungry;
            Habitat = "Earth";
            Nutrition = "Minerals";
            MovementSpeed = 1;
            Color = color.Red;
        }

        public Worm Clone() => new Worm { Name = this.Name, Age = this.Age };

        public string Name { get; set; }

        public int Age { get; set; }

        private Guid id = Guid.NewGuid();

        private bool IsHungry;

        public bool GetIsHungry() => IsHungry;

        public int GetMovementSpeed() => MovementSpeed;

        public string GetHabitat() => Habitat;

        public color GetColor() => Color;

        public void MoveUnderEarth()
        {
            if (IsHungry)
            {
                Console.WriteLine("Worm can't move, Worm needs some eat");
                IsHungry = false;
                Console.WriteLine($"Worm is eating {Nutrition} right now...");
            }
            Console.WriteLine($"Worm is moving rigth now with {MovementSpeed}m/s!!!");
            IsHungry = true;
        }

        public void FastMoving(int Speed)
        {
            IsHungry = false;
            MovementSpeed = Speed;
            Console.WriteLine($"Worm now is like Useyin Bold!!!\nMovement speed right now = {MovementSpeed}m/s");
            MovementSpeed = 1;
        }

        public void PrintInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all worms : {Habitat}");
            Console.WriteLine($"Nutrition of all worms : {Nutrition}");
            Console.WriteLine($"MovementSpeed of worm : {MovementSpeed}m/s");
            Console.WriteLine($"Color of all worms : {Color}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("=========================================");
        }

        public delegate void MessageHandler(string Message);

        public void ShowMessage(string Message, MessageHandler Handler)
        {
            Handler(Message);
        }

        ~Worm() { }
    }
}