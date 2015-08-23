using System;


namespace HW_Delegates
{
    public delegate double ArifmDelagate(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            ArifmDelagate add = (a, b) => a+b;
            ArifmDelagate substract = (a, b) => a - b;
            ArifmDelagate multiply = (a, b) => a*b;
            ArifmDelagate divide = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Error. Divide by zero");
                    return 0;
                }
                else
                {
                    return a/b;
                }
            };
            Console.WriteLine("Введите первое число:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип арифметической операции (+,-,*,/)");
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    {
                        Console.WriteLine("Result:{0}", add(firstNum,secondNum));
                    }
                    break;
                case '-':
                    {
                        Console.WriteLine("Result:{0}", substract(firstNum, secondNum));
                    }
                    break;
                case '*':
                    {
                        Console.WriteLine("Result:{0}", multiply(firstNum, secondNum));
                    }
                    break;
                case '/':
                    {
                        Console.WriteLine("Result:{0}", divide(firstNum, secondNum));
                    }
                    break;
                default:
                {
                    Console.WriteLine("Unknown type of operation");
                }
                    break;


            }
        }

        
            
        }
    }

