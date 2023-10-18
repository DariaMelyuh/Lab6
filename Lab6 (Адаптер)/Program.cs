namespace Lab6__Адаптер_
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck rubberDuck = new RubberDuck();
            Duck wildDuck = new WildDuck();

            Turkey turkey = new Turkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Резиновая утка:");
            rubberDuck.Quack();
            rubberDuck.Fly();

            Console.WriteLine("\nДикая утка:");
            wildDuck.Quack();
            wildDuck.Fly();

            Console.WriteLine("\nИндюк (адаптер):");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
            Console.ReadLine();
        }
    }
}



