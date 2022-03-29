using System;
using System.Linq;

namespace _01_Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string comm = commandArgs[0];
                

                if (comm == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (comm == "Reverse")
                {
                    string substringCommand = commandArgs[1];
                    if (message.Contains(substringCommand))
                    {
                        int firstIndexOffSubs = message.IndexOf(substringCommand);
                        message = message.Remove(firstIndexOffSubs, substringCommand.Length);
                        message = message + string.Join("", substringCommand.Reverse());

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (comm == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];
                    message = message.Replace(substring, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
