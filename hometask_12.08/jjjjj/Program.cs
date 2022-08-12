using System;
namespace hometask
{
    public class HomeTask1
    {

        //    // 1)Write a C# that calculates the day of week (ex: Monday) of your birthday
        //    static int dayofweek(int d, int m, int y)
        //    {
        //        int[] t = { 0, 3, 2, 5, 0, 3, 5,
        //                        1, 4, 6, 2, 4 };
        //        y -= (m < 3) ? 1 : 0;

        //        return (y + y / 4 - y / 100 + y / 400
        //                        + t[m - 1] + d) % 7;
        //    }
        //    public static void Maiin()
        //    {
        //        int day = dayofweek(30, 12, 2003);

        //        Console.Write(day);
        //    }
        //}

        //2)Write a C# that calculates you current life days (how many days past since your birth)
        //public static void Main()
        //{
        //    DateTime myBirthday = DateTime.Parse("30.12.2003");
        //    TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
        //    Console.WriteLine("You are " + myAge.TotalDays + " days old!");
        //    Console.ReadLine();
        //}

        //3)Write a C# Sharp program to find the largest of three numbers.
        //public static void Main()
        //{
        //    int num1, num2, num3;
        //    Console.Write("\n\n");
        //    Console.Write("Find the largest of three numbers:\n");
        //    Console.Write("------------------------------------");
        //    Console.Write("\n\n");

        //    Console.Write("Input the 1st number :");
        //    num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Input the  2nd number :");
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Input the 3rd  number :");
        //    num3 = Convert.ToInt32(Console.ReadLine());

        //    if (num1 > num2)
        //    {
        //        if (num1 > num3)
        //        {
        //            Console.Write("The 1st Number is the greatest among three. \n\n");
        //        }
        //        else
        //        {
        //            Console.Write("The 3rd Number is the greatest among three. \n\n");
        //        }
        //    }
        //    else if (num2 > num3)
        //        Console.Write("The 2nd Number is the greatest among three. \n\n");
        //    else
        //        Console.Write("The 3rd Number is the greatest among three. \n\n");
        //}

        // 4)Write a program in C# Sharp to read any day number in integer and display day name in the word
        //    public static void CheckDay()
        //{
        //    int dayno;

        //    Console.Write("\n\n");
        //    Console.Write("Accept day number and display its equivalent day name in word:\n");
        //    Console.Write("----------------------------------------------------------------");
        //    Console.Write("\n\n");


        //    Console.Write("Input Day No : ");
        //    dayno = Convert.ToInt32(Console.ReadLine());

        //    switch (dayno)
        //    {
        //        case 1:
        //            Console.Write("Monday \n");
        //            break;
        //        case 2:
        //            Console.Write("Tuesday \n");
        //            break;
        //        case 3:
        //            Console.Write("Wednesday \n");
        //            break;
        //        case 4:
        //            Console.Write("Thursday \n");
        //            break;
        //        case 5:
        //            Console.Write("Friday \n");
        //            break;
        //        case 6:
        //            Console.Write("Saturday \n");
        //            break;
        //        case 7:
        //            Console.Write("Sunday  \n");
        //            break;
        //        default:
        //            Console.Write("Invalid day number. \nPlease try again ....\n");
        //            break;
        //    }
        //}

        //5)Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
        //public static void Main()
        //{
        //    int num1, num2, opt;

        //    Console.Write("\n\n");
        //    Console.Write("A menu driven program for a simple calculator:\n");
        //    Console.Write("------------------------------------------------");
        //    Console.Write("\n\n");


        //    Console.Write("Enter the first Integer :");
        //    num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter the second Integer :");
        //    num2 = Convert.ToInt32(Console.ReadLine());


        //    Console.Write("\nHere are the options :\n");
        //    Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
        //    Console.Write("\nInput your choice :");
        //    opt = Convert.ToInt32(Console.ReadLine());

        //    switch (opt)
        //    {
        //        case 1:
        //            Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
        //            break;

        //        case 2:
        //            Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
        //            break;

        //        case 3:
        //            Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
        //            break;

        //        case 4:
        //            if (num2 == 0)
        //            {
        //                Console.Write("The second integer is zero. Devide by zero.\n");
        //            }
        //            else
        //            {
        //                Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
        //            }
        //            break;

        //        case 5:
        //            break;

        //        default:
        //            Console.Write("Input correct option\n");
        //            break;
        //    }
        //}

        //6)Write a program in C# to check whether a number is a palindrome (visual simmetric) or not
        //public static void Main()
        //{
        //    int num, r, sum = 0, t;


        //    Console.Write("\n\n");
        //    Console.Write("Check whether a number is a palindrome or not:\n");
        //    Console.Write("------------------------------------------------");
        //    Console.Write("\n\n");

        //    Console.Write("Input a number: ");
        //    num = Convert.ToInt32(Console.ReadLine());

        //    for (t = num; num != 0; num = num / 10)
        //    {
        //        r = num % 10;
        //        sum = sum * 10 + r;
        //    }
        //    if (t == sum)
        //        Console.Write("{0} is a palindrome number.\n", t);
        //    else
        //        Console.Write("{0} is not a palindrome number.\n", t);
        //}

        //7)Write a program in C# to create a function to calculate the sum of the individual digits of a given number
        //    public static int SumCal(int n)
        //    {
        //        string n1 = Convert.ToString(n);
        //        int sum = 0;
        //        for (int i = 0; i < n1.Length; i++)
        //            sum += Convert.ToInt32(n1.Substring(i, 1));
        //        return sum;
        //    }

        //    public static void Main()
        //    {
        //        int num;
        //        Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
        //        Console.Write("--------------------------------------------------------------------------\n");
        //        Console.Write("Enter a number: ");
        //        num = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));
        //    }

    }
}