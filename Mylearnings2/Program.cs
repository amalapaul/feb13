//FOR EACH LOOPS:- SIMPLER WAY TO ITERATE OVER AN ARRAY


/*String[] cars = { "BMW", "Tesla", "Audi" };
foreach (string car in cars)
{
    Console.WriteLine(car);
}*/
//----------------------------------------------------------------

//METHOD: -performs a section of code, whenever it's called "invoked".
//benefit---Let's us reuse code without writing it multiplt times


class Program
{
    static void Main(string[] args)
    {
        String name = "Amala";
        int age = 22;

        singHBD(name, age);
        singHBD(name, age);
       
    }


    static void singHBD(String name, int age)
    {
        Console.WriteLine("HBD to you!");
        Console.WriteLine("HBD to you!" + name);
        Console.WriteLine("HBD to you! .You are " + age + " years old" );
        Console.WriteLine("HBD to you!");
    }     
}
//------------------------------------------------------------------------




