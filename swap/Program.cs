using System;

    
    
        int n1, n2, temp;
        Console.Write("\n First Number : ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("\n Second Number : ");
        n2 = int.Parse(Console.ReadLine());
        temp = n1;
        n1 = n2;
        n2 = temp;
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + n1);
        Console.Write("\nSecond Number : " + n2);
        Console.Read();
    

