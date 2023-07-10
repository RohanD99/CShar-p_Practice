using System;
using System.Data.SqlClient;

namespace Bank
{
    internal class Program
    {
        private static string connectionString = "Server=TL097;Database=rdd;Integrated Security=True;";
        class App
        {
            Console.WriteLine("///Welcome to RD's Bank\\\\\\");
            Console.ReadLine();
            
            while(true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check balance");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        CheckBalance();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the Bank Console App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void CreateAccount()
        {
            Console.WriteLine("Create an Account");
            Console.WriteLine();

            Console.WriteLine("Enter customer name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter initial balance:");
            decimal balance = decimal.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Accounts (CustomerName, Balance) VALUES (@CustomerName, @Balance)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerName", name);
                command.Parameters.AddWithValue("@Balance", balance);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Account created successfully.");
                }
                else
                {
                    Console.WriteLine("Account creation failed.");
                }
            }
        }

            static void Deposit()
        {
            Console.WriteLine("Deposit");
            Console.WriteLine();

            Console.WriteLine("Enter account number:");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount to deposit");
            decimal amount = decimal.Parse(Console.ReadLine());

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountNumber = @AccountNumber";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Deposit Succesful");
                }
                else
                {
                    Console.WriteLine("Deposot failed");
                }
            }
        }

        static void Withdraw()
        {
            Console.WriteLine("Withdraw");
            Console.WriteLine();

            Console.WriteLine("Enter account number");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ammount to withdraw");
            decimal amount = decimal.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountNumber = @AccountNumber AND Balance >= @Amount";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Withdrawal successful");
                }
                else
                {
                    Console.WriteLine("Withdrawal failed");
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine("Check balance");
            Console.WriteLine();

            Console.WriteLine("Enter account number:");
            int accountNumber = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Balance FROM Accounts WHERE AccountNumber = @AccountNumber";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                connection.Open();
                

                object result = command.ExecuteScalar();

                if (result != null) 
                {
                    decimal balance = (decimal)result;
                    Console.WriteLine($"Account Balance: {balance}");                   
                }
                else
                {
                    Console.WriteLine("Account not found");
                }
            }
        }
    }
}
