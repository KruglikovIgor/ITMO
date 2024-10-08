// See https://aka.ms/new-console-template for more information
using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

class AreaOfTriangle
{
    public static void MyMetod()
    {
            Console.Write("Введите значение периметра треугольника: ");
            string temp = Console.ReadLine();
            double p = double.Parse(temp);
            double a = p / 3;
            double b = p / 3;
            double c = p / 3;
            p = p / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
           // temp= string.Format("{0:f2}", s);
            Console.WriteLine("Длина стороны" + "\t" + "Площадь");
            Console.WriteLine($"{b:0.00} \t\t   {s:0.00}");
            Console.ReadLine();
    }
}
class Program
{
    static void Main()
    {
        try
        {
            AreaOfTriangle.MyMetod();           
        }
        catch (FormatException e)
        {
            Console.WriteLine("ВНИМАНИЕ, введено некорректное значение: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("ВНИМАНИЕ, возникла исключительная ситуация: {0}", e.Message);
        }
    }
}

