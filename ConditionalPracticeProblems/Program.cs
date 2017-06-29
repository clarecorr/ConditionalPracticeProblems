using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            //Write a console application to ask the user for two integers. 
            //Check and see if the two integers are equal to each other. 
            //If they are, inform the the user that the numbers are equal, else inform the user that the numbers are not equal


            //Console.WriteLine("Please enter two numbers below");
            //Console.WriteLine("Enter your first number");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number");
            //int secondNumber = int.Parse(Console.ReadLine());

            //if (firstNumber == secondNumber)
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same numberS");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other");
            //}

            //2
            //Write a console application that asks the user for a number. Tell the user if that number is even or odd.

            //Console.WriteLine("Please enter an integer");
            //int number = int.Parse(Console.ReadLine());

            //int remainder = number % 2;

            //if(remainder == 0)
            //{
            //    Console.WriteLine(number + " is even");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is odd");
            //}

            //3
            //Write a console application that asks the user for a number and tells them if that number is a positive or negative number. 
            //What happens when the user enters 0? Is it positive or negative?

            //Console.WriteLine("Please enter a number");
            //double number = double.Parse(Console.ReadLine());

            //if(number>0)
            //{
            //    Console.WriteLine(number + " is positive");
            //}
            //else if(number<0)
            //{
            //    Console.WriteLine(number + " is negative");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is not positive or negative");
            //}

            //4
            //Write a console application to check whether a letter is a vowel or consonant

            //Console.WriteLine("Enter a letter");
            //string letter = Console.ReadLine();

            //switch (letter)
            //{
            //    case "a":
            //        Console.WriteLine("The letter " + letter + " is a vowel");
            //        break;
            //    case "e":
            //        Console.WriteLine("The letter " + letter + " is a vowel");
            //        break;
            //    case "i":
            //        Console.WriteLine("The letter " + letter + " is a vowel");
            //        break;
            //    case "o":
            //        Console.WriteLine("The letter " + letter + " is a vowel");
            //        break;
            //    case "u":
            //        Console.WriteLine("The letter " + letter + " is a vowel");
            //        break;
            //    case "y":
            //        Console.WriteLine("The letter " + letter + " is sometimes a vowel");
            //        break;
            //    default:
            //        Console.WriteLine("The letter " + letter + " is a consonant");
            //        break;        
            //}

            //5
            //Write a console application that prompts the user to input two integer values. 
            //Find and print the greatest value of the two integers. 

            //Console.WriteLine("Please enter three numbers below as prompted");
            //Console.WriteLine("Enter your first number");
            //double first = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number");
            //double second = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your third number");
            //double third = double.Parse(Console.ReadLine());

            //if(first > second && first >third)
            //{
            //    Console.WriteLine(first + " is the biggest number");
            //}
            //else if(second > first && second > third)
            //{
            //    Console.WriteLine(second + " is the biggest number");
            //}
            //else if(third > first && third > second)
            //{
            //    Console.WriteLine(third + " is the biggest number");
            //}
            //else if(first == second && second == third)
            //{
            //    Console.WriteLine(first + " is the biggest (and only) number");
            //}
            //else if (first == second && first > third)
            //{
            //    Console.WriteLine(first  + " is the biggest number");
            //}
            //else if (first == third && first > second)
            //{
            //    Console.WriteLine(first + " is the biggest number");
            //}
            //else if (second == third && second > first)
            //{
            //    Console.WriteLine(second + " is the biggest number");
            //}

            //6
            //Write a Console application that asks the user for 4 integers. 
            //Calculate the mean for these 4 numbers and display the result.

            Console.WriteLine("Please enter 4 integers as prompted below");
            Console.WriteLine("Enter your first integer");
            double firstInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second integer");
            double secondInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third integer");
            double thirdInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your fourth integer");
            double fourthInt = double.Parse(Console.ReadLine());

            double mean = (firstInt + secondInt + thirdInt + fourthInt) / 4;

            Console.WriteLine("The mean of these four numbers is " + mean);

            //I first made the 4 integers int type. This resulted in the mean being rounded down to the nearest integer even though I made mean a double. Why?

        }
    }
}
