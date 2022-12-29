// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Enter two integers to know the perfect numbers between them");

int num1 = int.Parse(Console.ReadLine());

int num2 = int.Parse(Console.ReadLine());

int sum = 0;

if (num1 <= 0 )
{
    Console.WriteLine("there is no perfect numbers");
}

else
{

    for (; num1 <= num2; num1++)
    {

        for (int i = 1; i < num1 ; i++)
        {

            if (num1 % i == 0)
            {
                sum = sum + i;
            }
        }
        if (sum == num1)

        {
            Console.WriteLine("{0} is a perfect number", num1);
        }
        sum = 0; 
        
    }
}


