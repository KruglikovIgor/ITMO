// See https://aka.ms/new-console-template for more information
using System;
class Greeter
{
    static void Main(string[] args)
    {
        string myName;
        Console.Write("Пожалуйста, введите Ваше имя:");
        myName = Console.ReadLine();
        Console.WriteLine("Здравствуйте, \t{0}!", myName);
    }
}    
