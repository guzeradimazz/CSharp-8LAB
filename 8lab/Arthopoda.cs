using System;
using System.Collections.Generic;

namespace _8lab
{
    class Insects
    {
        private List<Arthopoda> InsectsArmy = new List<Arthopoda>();
        public Arthopoda this[int index]
        {
            get
            {
                if (index < 0 && index >= InsectsArmy.Count)
                    throw new Exception("There is no arthopoda with such index\n");
                return InsectsArmy[index];
            }
            set
            {
                InsectsArmy.Add(value);
            }
        }
    }
    class Arthopoda : AnimalClass
    {
        Insects[] ArthopodaArray;

        public Arthopoda(int KilledFly)
        {
            ArthopodaArray = new Insects[50];
            this.KilledFly = KilledFly;
            KilledInLifetime = KilledFly;
            Habitat = "Trees";
            Nutrition = "Insects";
            MovementSpeed = 5;
            Color = color.White;
        }

        public Arthopoda()
        {
            ArthopodaArray = new Insects[50];
            KilledFly = 0;
            Habitat = "Trees";
            Nutrition = "Insects";
            MovementSpeed = 5;
            Color = color.White;
        }

        private int KilledFly, KilledInLifetime;

        public int GetMovementSpeed() => MovementSpeed;

        public string GetHabitat() => Habitat;

        public color GetColor() => Color;

        private Guid id = Guid.NewGuid();

        public void WeaveWeb()
        {
            if (KilledFly == 0)
                Console.WriteLine("This spider don't have enought fly's!\nYou need kill some fly's(Simply call function killFly()");
            else if (KilledFly > 0)
            {
                Console.WriteLine("Spider is weaving web...");
                Console.WriteLine("🕸🕸 🕸🕸 🕸🕸");
                Console.WriteLine(" 🕸🕸🕸🕸🕸🕸");
                Console.WriteLine("  🕸🕸🕷🕸🕸");
                Console.WriteLine("    🕸🕸🕸");
                Console.WriteLine("  🕸🕸🕸🕸🕸");
                Console.WriteLine("🕸🕸 🕸🕸 🕸🕸");
                KilledFly = 0;
            }
            else
                throw new Exception("Error program");
        }

        public void KillFly()
        {
            KilledFly++;
            KilledInLifetime++;
        }

        public void PrintInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all spider's : {Habitat}");
            Console.WriteLine($"Nutrition of all spider's : {Nutrition}");
            Console.WriteLine($"MovementSpeed of all spider's : {MovementSpeed} m/s");
            Console.WriteLine($"Color of all spider's : {Color}");
            Console.WriteLine($"This spider killed fly's : {KilledInLifetime}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("=========================================");
        }

        ~Arthopoda() { }

    }
}
