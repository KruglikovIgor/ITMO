// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;
class DivideIt
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите первое целое число: ");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);
            Console.Write("Введите второе целое число: ");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);
            int k = i / j;
            temp = k.ToString();
            Console.Write("Сумма чисел=" + k.ToString());
        }
        catch (FormatException e)
        {
            Console.WriteLine("ВНИМАНИЕ, введено некорректное значение: {0}",  e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("ВНИМАНИЕ, возникла исключительная ситуация: {0}", e.Message);
        }
        //catch (Exception e)
        //{
        //    Console.WriteLine("ВНИМАНИЕ, возникла исключительная ситуация: {0}",  e.Message);
        //}

    }
}
