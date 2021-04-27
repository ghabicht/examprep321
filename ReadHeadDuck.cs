using System;
namespace examprep
{
    public class ReadHeadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}