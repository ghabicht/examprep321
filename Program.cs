using System;

namespace examprep
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulate();
        }

        public static void Simulate(){

            AbstractDuckFactory duckFacotry = new CountingDuckFactory();
            IQuackable duckCall = duckFacotry.CreateDuckCall();
            IQuackable mallard = duckFacotry.CreateMallardDuck();
            IQuackable readHead = duckFacotry.CreateRedHead();
            IQuackable rubber = duckFacotry.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());


            Console.WriteLine("Duck Simulator");
            Simulate(duckCall);
            Simulate(mallard);
            Simulate(readHead);
            Simulate(rubber);
            Simulate(gooseDuck);

            Console.WriteLine("The ducks quacked " + QuackCounter.GetNumberOfQuacks() + " times");
        }

        public static void Simulate(IQuackable duck){
            duck.Quack();
        }
    }
}
