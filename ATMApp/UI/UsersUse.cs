using System;
using System.Collections.Generic;
using System.Text;


namespace ATMApp.UI

{ 
    public static class UsersTask

    //method 1 to show users pin as asterisk
    {
        public static string GetSecretPin(string prompt)
        {   
            bool IsPrompt = true;
            string Asteriks = " ";
            StringBuilder Input = new StringBuilder();

            while (true)
            {
                if (IsPrompt)
                    Console.WriteLine(prompt);
                IsPrompt = false;
                ConsoleKeyInfo InputKey = Console.ReadKey(true);
                if(InputKey.Key == ConsoleKey.Enter)
                {
                    if (Input.Length == 4)
                    { break; }
                }
               
                else
                {
                    PrintMessage("Please enter your four digit number", false);
                    IsPrompt = true;
                    Input.Clear();
                }
                if (InputKey.Key == ConsoleKey.Backspace && Input.Length > 0)
                {
                    Input.Remove(Input.Length - 1, 1);
                }
                else if (InputKey.Key != ConsoleKey.Backspace)
                {
                    Input.Append(InputKey.KeyChar);
                    Console.Write(Asteriks + "*");
                }
            }
            return Input.ToString();
           
    }



    //method to print success or error message using color to users
    public static void PrintMessage(string Msg, bool Success = true)
    {
        if (Success)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else { Console.ForegroundColor = ConsoleColor.Red; }

        Console.WriteLine(Msg);
        PressEnterToContinue();

    }
   
    //method to collect users input
  public static string GetUsersInput(string prompt) {
            Console.WriteLine($"Enter your {prompt}");
            return Console.ReadLine();
        } 
    //method to move user to another task or function
       public static void PressEnterToContinue()
        {
            Console.ReadLine();
            Console.WriteLine("\nPress Enter to Continue.....");
           

        }
    }
}

