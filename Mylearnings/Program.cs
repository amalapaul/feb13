// typecasting: converting a value to a diff data type 
//double a = 3.14;
//int b = Convert.ToInt32(a);

using System;
using System.Diagnostics;

/*int c = 123;
double d = Convert.ToDouble(c);
Console.WriteLine(d.GetType());

int e = 321;
string s = Convert.ToString(e);
Console.WriteLine(s.GetType());

string g = "$";
char h = Convert.ToChar(g);
Console.WriteLine(h.GetType());

string i = "true";
bool b = Convert.ToBoolean(i);
Console.WriteLine(b.GetType());*/



//storing and reading value
/*Console.WriteLine("Enter your name: ");
string? name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Hello " + name);
Console.WriteLine("You are " + age + " years old");*/



//Arithmetic Operators
int frnd = 50;
/*frnd++; 
frnd += 2;
frnd -= 1;
frnd *= 3;
frnd /= 2;
Console.WriteLine(frnd);   */
int rem = frnd % 3;
Console.WriteLine(rem);



//to find hyp of triangle
/*Console.WriteLine("Enter the opposite side length: ");
double o = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the adjacent side length: ");
double a = Convert.ToDouble(Console.ReadLine());

double hyp = Math.Sqrt((o * o) + (a * a));
Console.WriteLine("Hypotonuse is: " + hyp);*/



//string methods
String fullName = "Amala Paul";
String phoneNumber = "123-456-7890";

/*fullName = fullName.ToUpper();
fullName = fullName.ToLower();  */

phoneNumber = phoneNumber.Replace("-", "/");
Console.WriteLine(phoneNumber);

String username = fullName.Insert(0, "@");
Console.WriteLine(username);

Console.WriteLine(fullName.Length);

String firstName = fullName.Substring(0, 3);
Console.WriteLine(firstName);

String lastName = fullName.Substring(6, 4);
Console.WriteLine(lastName);



//if statement
/*Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are signed up!");
}
else
{
    Console.WriteLine("Sorry Underage!");
}

Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

if (name == "") 
{
    Console.WriteLine("You didn't entered the name!");
}
else
{
    Console.WriteLine("Hello "+ name);
}*/




//switch
Console.WriteLine("What day is today? :");
String day = Console.ReadLine();
 
/*switch(day)
{
    case "Monday":
        Console.WriteLine("Its monday.");
        break;
    case "Tuesday":
        Console.WriteLine("Its tuesday.");
        break;
    case "Wednesday":
        Console.WriteLine("Its Wednesday");
        break;
    case "Thursday":
        Console.WriteLine("Its Thursday");
        break;
    case ":Friday":
        Console.WriteLine("Its Friday");
        break;
    case "Saturday":
        Console.WriteLine("Its Saturday");
       break;

}*/



// for loops = repeats code a finite amount of times

//for (int i = 0; i < 10; i+=2) increment by 2-> 1,3,5,7,9
/* for (int i = 0 ; i < 10 ; i++)
{
 Console.WriteLine(i);
}
*/

  for (int i = 10; i > 0; i--)
  {
      Console.WriteLine(i);
  }
  Console.WriteLine("Happy New Year");



//nested loops  - to create a rectangle
/*Console.Write("How many rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("How many columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Which symbol: ");
String symbol = Console.ReadLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}*/




//calculator progrm

double result = 0;
Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an option");
Console.WriteLine("\t+ : Add");
Console.WriteLine("\t- : Subtract");
Console.WriteLine("\t* : Multiply");
Console.WriteLine("\t/ : Divide");

/*switch (Console.ReadLine())
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
        break;

    case "-":
        result = num1 - num2;
        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
        break;

    case "*":
        result = num1 * num2;
        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
        break;

    case "/":
        result = num1 / num2;
        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
        break;

}*/



//Arrays: a variable that can store multiple values, fixed size

String[] cars = { "BMW", "Mustang", "Nano" };

cars[0] = "tesla";

//Console.WriteLine(cars[0]);
//Console.WriteLine(cars[1]);

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}


String[] animals = new string[3];
animals[0] = "Tiger";
animals[1] = "Cat";

for (int j = 0; j < animals.Length; j++)
{
    Console.WriteLine(animals[j]);
}











