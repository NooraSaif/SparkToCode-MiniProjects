using System.Xml.Linq;

namespace MiniProject1_BankingManagementConsoleApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        //DepositMoney();
                        break;
                    case 3:
                        //WithdrawMoney();
                        break;
                    case 4:
                        //ShowBalance();
                        break;
                    case 5:
                        //TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        //// ===================== SERVICE FUNCTIONS =====================
        //// Each function owns ONE service end-to-end: it asks the user for
        //// whatever it needs, validates it, updates the shared lists, and
        //// prints the outcome. Main never reads input or prints results
        //// for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            Console.WriteLine("Enter your name");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter your Account number");
            string customerAccount = Console.ReadLine();

            if (accountNumbers.Contains(customerAccount))
            {
                Console.WriteLine("The account number is already exist");
                return;
            }

            try
            {
                Console.WriteLine("Add an initial deposit amount to open your accoun: ");
                double initialAmount = Convert.ToDouble(Console.ReadLine());

                if (initialAmount < 0)
                {
                    Console.WriteLine("The amount cannot be negative.");
                    return;
                }

                customerNames.Add(customerName);
                accountNumbers.Add(customerAccount); 
                balances.Add(initialAmount);

                Console.WriteLine($"Account successfully created for {customerName}!");
                Console.WriteLine($"Account Number: {customerAccount} with balance: {initialAmount}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount input");
            }
        }

        //static void DepositMoney()
        //{
            

        //}

        //static void WithdrawMoney()
        //{
        //    // TODO: implement this service (see Section 3 requirements)
        //}
        //static void ShowBalance()
        //{
        //    // TODO: implement this service (see Section 3 requirements)
        //}
        //static void TransferAmount()
        //{
        //    // TODO: implement this service (see Section 3 requirements)
        //}
        //// TODO: write two more void, no-parameter functions here for
        //// your own custom services (option 6 and option 7)
    }
}

