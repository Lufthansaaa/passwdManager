using System;
using System.IO;

#pragma warning disable CS8604
#nullable enable

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true) // Loop indefinitely until the user chooses to exit
            {
                Console.Clear();
                Console.Write("Store or create file (store/create)? ");
                string? storeCreate = Console.ReadLine();
                if (storeCreate == "create")
                {
                    Console.Write("Enter file name: ");
                    string? fileName = Console.ReadLine();
                    using (FileStream fileStream = File.Create(fileName))
                    {
                        // File created, do any additional operations if needed
                    }
                }
                else if (storeCreate == "store")
                {
                    Console.Clear();
                    Console.Write("Please enter category (e.g. chess): ");
                    string? category = Console.ReadLine();
                    Console.Write("Enter username/email: ");
                    string? user = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string? password = Console.ReadLine();
                    Console.Write("Enter file path: ");
                    string? path = Console.ReadLine();
                    File.AppendAllText(path, $"\nCategory: {category}\nUsername/Email: {user}\nPassword: {password}");
                }

                Console.Write("Do you want to do it again (yes/no)? ");
                string? doAgain = Console.ReadLine();
                if (doAgain != "yes")
                {
                    break; // Exit the loop if the user doesn't want to repeat
                }
            }
        }
    }
}
