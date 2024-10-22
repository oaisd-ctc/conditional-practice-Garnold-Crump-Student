
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        CheckForPositiveNegativeZero();
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        FindMinimum();
        FindMax();
        DivisibleBy5();
        EvenOrOdd();
        CheckVowelOrConsonant();
        DisplayDayOfWeek();

    }
    public static void CheckForPositiveNegativeZero()
    {
        Console.WriteLine("Is your number negative or positive");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input > 0)
        {
            Console.WriteLine("your number is positive");
        }
        else if (input == 0)
        {
            Console.WriteLine("your number is Zero");
        }
        else
        {
            Console.WriteLine("your number is negative");
        }

    }

    public static void FindMinimum()
    {
        Console.WriteLine("find the minimum of 3 numbers of your choice");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max2 = Math.Min(num3, Math.Min(num1, num2));
        Console.WriteLine("the minimum is " + (max2));

    }
    public static void FindMax()
    {
        Console.WriteLine("find the maximum of 3 numbers of your choice");

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max1 = Math.Max(num2, Math.Max(num1, num3));

        Console.WriteLine("The greatest number is " + (max1));
    }


    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }


    public static void DivisibleBy5()
    {
        Console.WriteLine("Is your number divisble by 5");
        int myNum = Convert.ToInt32(Console.ReadLine());
        if (myNum % 5 == 0)
        {
            Console.WriteLine("its divisble by 5");
        }

        else
        {
            Console.WriteLine("Its not divisible by 5");
        }


    }
    public static void EvenOrOdd()
    {
        Console.WriteLine("is your number even or odd");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine((num) + " is even");
        }
        else
        {
            Console.WriteLine((num) + " is odd");
        }
    }
    public static void CheckVowelOrConsonant()
    {
        Console.WriteLine("Is your letter a vowel or a constant");
        char vowel = Convert.ToChar(Console.ReadLine());
        if (vowel == 'a')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'A')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'e')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'E')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'i')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'I')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'o')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'O')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'u')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else if (vowel == 'U')
        {
            Console.WriteLine((vowel) + " is a vowel");
        }
        else
        {
            Console.WriteLine((vowel) + " is a Consonant");
        }

    }
    public static void DisplayDayOfWeek()
    {
        Console.WriteLine("What number day of a week is it.");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 0:
                Console.WriteLine("Monday");
                break;
            case 1:
                Console.WriteLine("Tuesday");
                break;
            case 2:
                Console.WriteLine("Wednesday");
                break;
            case 3:
                Console.WriteLine("Thursday");
                break;
            case 4:
                Console.WriteLine("Friday");
                break;
            case 5:
                Console.WriteLine("Saturday");
                break;
            case 6:
                Console.WriteLine("Sunday");
                break;
        }
    }



}












