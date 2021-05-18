using System;
using System.Threading;
namespace _8lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate
            Bear TestBear = new Bear();
            Console.WriteLine("This is Bear's deletate ^^^");
            Thread.Sleep(2000);
            Console.WriteLine();
            TestBear.GoodEvening();
            Console.WriteLine("This is my invokation deletate ^^^");

            //Anonimus function
            Console.WriteLine();
            Worm TestWorm = new Worm();
            Console.WriteLine("Enter message that you want worm said");
            string Message = Console.ReadLine();
            TestWorm.ShowMessage(Message, delegate (string Message)
            {
                Console.WriteLine(Message);
            });

            //Lambda expression
            Console.WriteLine();
            Fish TestFish = new Fish();
            Console.WriteLine(TestFish.GetColor());
            Console.WriteLine(TestFish.GetHabitat());
            Console.WriteLine(TestFish.GetMovementSpeed());

            //Event
            Console.WriteLine();
            TestFish.Added += Fish.Display;
            TestFish.Substract += Fish.Display;
            TestFish.EatGreenFood(100);
            TestFish.Withdraw(50);
            TestFish.Withdraw(100);

            Console.ReadKey();
        }
    }
}
