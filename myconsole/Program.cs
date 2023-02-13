//STRING INTERPOLATION

int a = 100;
float b = 250.0f;
string c = "Hello";

Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

//using string interpolation we can write the values inside itself
Console.WriteLine($"The values are {a}, {b} and {c}");

//interpolated strings can contain expressions as well
Console.WriteLine($"(a + b)/b is {(a + b)/b} ");
Console.WriteLine($"{c} in upper case is {c.ToUpper()}");

//complex objects can be embeded in strings this way as well
DateTime now = DateTime.Now;
Console.WriteLine($"Today is {now}");
//-------------------------------------------------------------------------------------


// STRING FORMATTING

float f1 = 123.4f;
int i1 = 2000;

//Spacing and alignment : indexes
Console.WriteLine("{0, -15} {1, 10}", "Float val", "Int val");
Console.WriteLine("{0, -15} {1, 10}", f1, i1);

//Spacing and alignment : interpolation
Console.WriteLine("{0, -15} {1, 10}", "Float val", "Int val");
Console.WriteLine($"{f1, -15} {i1, 10}");

//---------------------------------------------------------------------------------------


//STRING MANIPULATION

string str1 = "Hello";
string str2 = "This is a string.";
string str3 = "This is a message.";
string[] strs = {"one","two","three","Four" };

//length of a string
Console.WriteLine(str1.Length);

//Access individual characters
Console.WriteLine(str1[14]);


//iterate over a string

//foreach (char ch in str1)
//{
//    Console.WriteLine(ch);
//	if (ch == 'b')
//	{
//		Console.WriteLine();
//		break;
//	}
//}














