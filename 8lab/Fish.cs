using System;
namespace _8lab
{

    delegate void FishStateHandler(string message);

    class Fish : AnimalClass, IAnimalAffairs
    {
        public Fish()
        {
            Habitat = "Water";
            Nutrition = "Green and fishes";
            MovementSpeed = 20;
            Color = color.Blue;
        }

        public event FishStateHandler Added;

        public event FishStateHandler Substract;

        public int SleeppingHours { get; set; }

        public int Children = 0, GreenFood = 0;

        public void EatGreenFood(int _GreenFood)
        {
            GreenFood += _GreenFood;
            if (Added != null)
                Added($"Fish eat {_GreenFood}");
            else
                throw new Exception("Error program");
        }

        public void Withdraw(int _GreenFood)
        {
            if (GreenFood >= _GreenFood)
            {
                GreenFood -= _GreenFood;
                if (Substract != null)
                    Substract($"Fish withdraw {_GreenFood}");
            }
            else if (GreenFood < _GreenFood)
            {
                if (Substract != null)
                    Substract("Fish don't have enought food");
            }
            else
                throw new Exception("Error program");
        }

        public static void Display(string message)
        {
            Console.WriteLine(message);
        }

        private Guid id = Guid.NewGuid();

        public int GetMovementSpeed() => MovementSpeed;

        public string GetHabitat() => Habitat;

        public color GetColor() => Color;

        private bool IsHungry = true;

        public void SleepDeep()
        {
            Children += 10;
            SleeppingHours += 4;
            Console.WriteLine($"This fish is sleepping a lot of time!\nRight now this fish have {Children} childs");
        }

        public void EatGreen()
        {
            IsHungry = false;
            Console.WriteLine("Fish is eating right now!");
        }

        public void Reproduction()
        {
            if (!IsHungry)
            {
                Console.WriteLine("Fish is ready to reproducing");
                Children++;
                Console.WriteLine("Fish reproduce 1 children");
            }
            else if (IsHungry)
                Console.WriteLine("Fish is to hungry\nJust call function eatGreen()");

            else
                throw new Exception("Error program");
        }

        public void PrintInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all Fishes : {Habitat}");
            Console.WriteLine($"Nutrition of all Fishes : {Nutrition}");
            Console.WriteLine($"MovementSpeed of all Fishes : {MovementSpeed}m/s");
            Console.WriteLine($"Color of all Fishes : {Color}");
            Console.WriteLine($"Childrens of this Fish : {Children}");
            Console.WriteLine($"ID: {id}");
            if (SleeppingHours > 0)
                Console.WriteLine($"This fish sleeps {SleeppingHours} hours");
            Console.WriteLine("=========================================");
        }

        public virtual void Swimming()
        {
            Console.WriteLine("Fish is swimming");
        }

        ~Fish() { }
    }
    class Caras : Fish
    {
        public int FishesEated = 0;

        public void EatOtherFish()
        {
            FishesEated++;
        }

        public void GetEatedFishes()
        {
            Console.WriteLine($"This caras eated {FishesEated} fishes");
        }

        public override void Swimming()
        {
            Console.WriteLine("I swim like CARAS");
        }
    }

    class Schuka : Fish
    {
        public override void Swimming()
        {
            Console.WriteLine("I swim like SCHUKA");
        }
    }
}
