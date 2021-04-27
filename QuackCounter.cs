using System;
namespace examprep
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int duckQuacks;
        
        public QuackCounter(IQuackable duck){
            this.duck = duck;
        }
        
        public void Quack()
        {
            duck.Quack();
            duckQuacks++;
        }

        public static int GetNumberOfQuacks(){
            return duckQuacks;
        }
    }
}