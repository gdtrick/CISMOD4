using System;

namespace Bank_XYZ
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            double checkingBalance = 245.37;
            double savingsBalance = 785.63;

            double depositAmount = 0;
            double withdrawAmount = 0;
            double transferAmount = 0;

            int menuOption = 0;
            int atmPIN = 0;

            //Input PIN number
            Console.WriteLine("Please enter 4 digit PIN Number");
            atmPIN = int.Parse(Console.ReadLine());

            //Menu Options
            if (atmPIN == 4298)

            {
                Console.WriteLine("Thank You For Choosing XYZ Banking Services. How can we help you today?");
                Console.WriteLine("1. Check Account Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("Please use the keypad to enter your choice: ");
                menuOption = int.Parse(Console.ReadLine());
            }

            else
            {
                Console.WriteLine("INVALID PIN. Please try again.");
            }

            //Check Account Balance
            if (menuOption == 1)

            {
                Console.WriteLine("Your current checking account balance is: " + checkingBalance);
                Console.WriteLine("your current savings account balance is: " + savingsBalance);
            }

            //Withdraw Funds from Checking/Savings Account
            if (menuOption == 2)

            {
                Console.WriteLine("Your current balance is: " + checkingBalance);
                Console.WriteLine("Please enter the amount you wish to withdraw: ");
                withdrawAmount = double.Parse(Console.ReadLine());

                if (withdrawAmount > checkingBalance)
                {
                    Console.WriteLine("Insufficient funds available for withdraw.");
                }

                else
                {
                    checkingBalance = checkingBalance - withdrawAmount;
                    Console.WriteLine("Be sure to collect your money before leaving this machine.");
                    Console.WriteLine("Your remaining account balance is: " + checkingBalance);
                }

            }

            //Deposit Funds into Checking/Savings Account
            if (menuOption == 3)

            {
                Console.WriteLine("Your current balance is: " + checkingBalance);
                Console.WriteLine("Please enter the amount you wish to deposit: ");

                depositAmount = double.Parse(Console.ReadLine());
                checkingBalance = checkingBalance + depositAmount;

                Console.WriteLine("The amount you requested has successfully been deposited into your account.");
                Console.WriteLine("Your new checking account balance is: " + checkingBalance);
            }

            //Transfer Money from Savings Account to Checking Account, from Checking Account to Savings Account
            if (menuOption == 4)

            {
                Console.WriteLine("Your current checking account balance is: " + checkingBalance);
                Console.WriteLine("Your current savings account balance is: " + savingsBalance);
                Console.WriteLine("Please enter the amount you wish to transfer: ");

                transferAmount = double.Parse(Console.ReadLine());
                checkingBalance = checkingBalance + transferAmount;
                savingsBalance = savingsBalance - transferAmount;

                Console.WriteLine("The amount you requested has successfully been transfered from your savings account into your checking account.");
                Console.WriteLine("Your new checking account balance is: " + checkingBalance);
                Console.WriteLine("Your new savings account balance is: " + savingsBalance);
            }

        }

    }
}