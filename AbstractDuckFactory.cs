namespace examprep
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRedHead();
        public abstract IQuackable CreateRubberDuck();
    }
}