using System;
using System.Collections.Generic;
using System.Text;


namespace ATMApp.UI { 
     public static class UsersTask
{
    //method to print success or error message using color to users
    public static void PrintMessage(string Msg, bool Success = true)
    {
        if (Success)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else { Console.ForegroundColor = ConsoleColor.Red; }

        Console.WriteLine(Msg);
        Console.ResetColor();
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

