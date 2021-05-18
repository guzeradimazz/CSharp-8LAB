using System;
namespace _8lab
{
    enum color
    {
        Red,
        Green,
        White,
        Orange,
        Blue,
        Brown,
        Yellow
    }
    abstract class AnimalClass
    {
        public AnimalClass() { }
        public color Color;
        public string Habitat;
        public string Nutrition;
        public int MovementSpeed;
        ~AnimalClass() { }
    }
    interface IAnimalAffairs
    {
        int SleeppingHours { get; set; }
        void SleepDeep();
    }
    interface ICloneable<Type>
    {
        Type Clone();
    }
}
