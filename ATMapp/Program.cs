//atm app
using System;

namespace ATMapp
{
    class ATM
    {

        public double currAmount = 400.00;
        //method to show menu
        public static void showMenu()
        {

            Console.WriteLine("*************MENU*************");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Make Withdrawal");
            Console.WriteLine("4. Exit");
            Console.WriteLine("******************************");

        }

        //method to show current balance
        public void GetCurrentBalance()
        {
            Console.WriteLine($"Current Balance: {currAmount:C}");
        }


        //method to deposit
        public double Deposit()
        {
            Console.WriteLine("**********Make Deposit**********");
            Console.Write("Enter deposit amount: ");
            double amtDeposit = Convert.ToDouble(Console.ReadLine());
            currAmount += amtDeposit;
            Console.WriteLine($"Current Balance: {currAmount:C}");
            return currAmount;
        }

        public double Withdraw() 
        {
            Console.WriteLine("*********Make Withdrawal**********");
            Console.Write("Enter amount to withdraw: ");
            double amtWithdraw = Convert.ToDouble(Console.ReadLine());
            if (amtWithdraw > currAmount)
            {
                Console.WriteLine("Insufficient balance!Cannot withdraw");
            }
            else
            {
                currAmount -= amtWithdraw;
                Console.WriteLine($"Current balance {currAmount:C}");
            }

            return currAmount;

        }

        static void Main(string[] args)
        {

            byte option;
            string userInput;
            ATM atm1 = new ATM(); 
            
            do
            {
                showMenu(); 
                Console.Write("Enter option: ");
                userInput = Console.ReadLine();
                option = Convert.ToByte(userInput);
                Console.Clear();
                switch (option)
                {
                    case 1: atm1.GetCurrentBalance();//Console.WriteLine($"Current Balance is: {atm1.currAmount:C}"); 
                        break;
                    case 2:atm1.Deposit();
                        break;
                        
                    case 3:atm1.Withdraw();
                        break;

                }

            } while (option != 4);
                  
        }
    }
}
    