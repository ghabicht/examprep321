namespace examprep
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedHead()
        {
          return new QuackCounter(new ReadHeadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
           return new QuackCounter(new RubberDuck());
        }
    }
}