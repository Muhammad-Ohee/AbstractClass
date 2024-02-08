//Console.WriteLine("Hello, OS");

namespace ElectricityBills
{
    public abstract class Plan
    {
        protected abstract double GetRate();

        public void Calculation(int units)
        {
            double rate = GetRate();
            Console.WriteLine($"Bill Amount For {units} Units is: Taka. {rate * units}");
        }
    }

    class CommercialPlan : Plan
    {
        protected override double GetRate()
        {
            return 5.00;
        }
    }

    class DomesticalPlan : Plan
    {
        protected override double GetRate()
        {
            return 2.50;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plan plan;

            Console.WriteLine("Commercial Plan");
            plan = new CommercialPlan();
            plan.Calculation(100);

            Console.WriteLine("Domestical Plan");
            plan = new DomesticalPlan();
            plan.Calculation(10);
        }
    }
}