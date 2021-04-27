using System;
namespace examprep
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}