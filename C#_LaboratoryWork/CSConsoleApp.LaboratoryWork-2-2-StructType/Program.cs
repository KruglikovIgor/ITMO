
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSConsoleApp.LaboratoryWork_2_2_StructType
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    public class Program
    {
        public static void Main()
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.Write("Введите номер счета: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            Console.WriteLine("Номер счета: {0}", goldAccount.accNo);
            Console.WriteLine("Проверка счета: {0}", goldAccount.accType);
            Console.WriteLine("Баланс счета: ${0}", goldAccount.accBal);
            Console.ReadLine();
        }
    }
}
