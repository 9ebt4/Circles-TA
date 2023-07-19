using Circle_Object;
using Validator_Object;


bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Enter a radius.");
    Circle newCircle = new Circle(Validator.DoubleValidator());
    Console.WriteLine($"Diameter:{newCircle.CalculateDiameter()}");
    Console.WriteLine($"Circumference:{newCircle.CalculateCircumference()}");
    Console.WriteLine($"Area:{newCircle.CalculateArea()}");

    while (true)
    {
        Console.WriteLine("Make it grow?");
        bool response = Validator.Continue();
        if(response)
        {
            newCircle.Grow();
            Console.WriteLine($"Diameter:{newCircle.CalculateDiameter()}");
            Console.WriteLine($"Circumference:{newCircle.CalculateCircumference()}");
            Console.WriteLine($"Area:{newCircle.CalculateArea()}");
        }
        else
        {
            Console.WriteLine("GoodBye");
            Console.WriteLine($"Ending Radius: {newCircle.GetRadius()}");
            runProgram = response; 
            break;
        }
    }
}
