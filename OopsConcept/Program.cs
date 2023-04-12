namespace OopsConcept
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concept");
            Console.WriteLine("Please choose any one program given below");
            Console.WriteLine("n1:Mghector\n2.JohnDeere\n3.MethodOverloading\n4.MethodOverriding");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    // Single inheritance
                    Mghector myCar = new Mghector();
                    myCar.model = "Turbo hector 1.5";
                    myCar.colour = "White";
                    myCar.price = 1400000;
                    myCar.mileage = 13.79f;
                    myCar.PrintCarDetails();
                    myCar.PrintMileage();
                    break;
                    // Multilevel inheritance
                case 2:
                    JohnDeere tractor = new JohnDeere();
                    tractor.brand = "No 1 Sonalika brand";
                    tractor.moDel = "Sonalika Sikandar DI 55 Dlx";
                    tractor.price = 870000;
                    tractor.colour = "Red";
                    tractor.Hp = 55;
                    tractor.description = "Cylinde:4 Nos,Gearbox:8 Forword 2 Riverse,Brakes:Oil immersed";
                    tractor.TractorInformation();
                    tractor.PrintColour();
                    tractor.SpecificDetails();
                    break;
                    // Method Overloading
                case 3:
                    Programs myObj = new Programs();
                    myObj.Sum(5, 4.5f, 7);
                    break;
                    // Method Overriding
                case 4:
                     Dog tommy = new Dog();
                     tommy.Eat();
                    break;
                default:
                    Console.WriteLine("Please select the program given below option");
                    break;

            }
           
        }
    }
}