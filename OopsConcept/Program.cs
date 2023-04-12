namespace OopsConcept
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concept");

            // Sinle inheritance
            Mghector myCar = new Mghector();
            myCar.model = "Turbo hector 1.5";
            myCar.colour = "White";
            myCar.price = 1400000;
            myCar.mileage = 13.79f;
            myCar.PrintCarDetails();
            myCar.PrintMileage();
        }
    }
}