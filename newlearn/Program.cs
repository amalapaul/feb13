/*// C# program to illustrate the
// Initialization of an object
using System;

// Class Declaration
public class Dog
{

    // Instance Variables
    String name;
    String breed;
    int age;
    String color;

    // Constructor Declaration of Class
    public Dog(String name, String breed,
                int age, String color)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
        this.color = color;
    }

    // Property 1
    public String GetName()
    {
        return name;
    }

    // Property 2
    public String GetBreed()
    {
        return breed;
    }

    // Property 3
    public int GetAge()
    {
        return age;
    }

    // Property 4
    public String GetColor()
    {
        return color;
    }

    // Method 1
    public String ToString()
    {
        return ("Hi my name is " + this.GetName()
                + ".\nMy breed, age and color are " + this.GetBreed()
                + ", " + this.GetAge() + ", " + this.GetColor());
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating object
        Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
        Console.WriteLine(tuffy.ToString());
    }
}
*/


/* Write a program in C# Sharp to store elements in an array and print it.

Test Data:
Input 10 elements in the array:
element - 0 : 1
element - 1 : 1
element - 2 : 2.......
Expected Output :
Elements in array are: 1 1 2 3 4 5 6 7 8 */


//int[] num = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter the elements in array: ");
//    Console.ReadLine();
//}
//foreach (int item in num)
//{
//    Console.WriteLine(item);

//}


//23Jan2023

using newlearn;

human human1 = new human()
{
    name = "Rick",
    age = 30
};
human1.Eat();
human1.sleep();


//int[] numbers = { 1, 3, 4, 9, 2 };
//int numToRemove = 4;
//numbers = numbers.Where(val => val != numToRemove).ToArray();

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

