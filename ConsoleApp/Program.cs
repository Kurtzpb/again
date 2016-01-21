using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            double operand1 = 56;
            double operand2 = 0;

            Console.WriteLine("Введите оператор:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.Write(operand1 + operand2);
                        break;
                    }
                case "-":
                    {
                        Console.Write(operand1 - operand2);
                        break;
                    }
                case "*":
                    {
                        Console.Write(operand1 * operand2);
                        break;
                    }
                case "/":
                    {
                        if (operand2 != 0)
                        {
                            Console.Write(operand1 / operand2);
                        }
                        else { Console.WriteLine("Делитель не должен быть равен нулю"); }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы не ввели корректный оператор!");
                        break;
                    }
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
