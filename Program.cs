using System;

//namespace SistaMiniraknare
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            using System;

namespace SistaMiniraknare

{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator");
                Console.WriteLine("------------------");

                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an operator option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an operator option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        //result = num1 + num2;
                        //Console.WriteLine($"Your result: {num1} + {num2} = " + result);

                        result = Addition(num1, num2);
                        Console.WriteLine($"Your result is: {num1} + {num2} = {result}");


                        break;
                    case "-":
                        //result = num1 - num2;
                        //Console.WriteLine($"Your result: {num1} - {num2} = " + result);

                        result = Subtraction(num1, num2);
                        Console.WriteLine($"Your result is: {num1} - {num2} = {result}");

                        break;
                    case "*":
                        //result = num1 * num2;
                        //Console.WriteLine($"Your result: {num1} * {num2} = " + result);

                        result = Multiplication(num1, num2);
                        Console.WriteLine($"Your result is: {num1} * {num2} = {result}");

                        break;
                    case "/":
                        //result = num1 / num2;
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by 0");
                        }
                        else
                        {
                            result = Division(num1, num2);
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        }
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;


                }

                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("See Ya!");
            Console.ReadKey();
        }

        public static double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public static double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        public static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public static double Division(double num1, double num2)
        {

            if (num2==0)
            {
                return double.NaN;

            }

            double result = num1 / num2;
            return result;

        }
        public static double Addition(double[] numArray)
        {
            double sumArray;
            sumArray=numArray[0]+numArray[1];
            return sumArray;
        }

        public static double Subtraction(double[] numArray)
        {
            double sumArray;
            sumArray=numArray[0]-numArray[1];
            return sumArray;
        }

    }
}

