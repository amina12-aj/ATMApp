using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class Welcome
    {
        public static void Message()
        {
            Console.Title = "My ATM App";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------Welcome to My ATM App-------------\n");
            Console.WriteLine("Kindly Insert your Card\n");
            Console.WriteLine("Note: In a physical ATM, you will be required to insert your ATM card.\n");
            Console.WriteLine("Press Enter to Continue....");
            UsersTask.PressEnterToContinue();

        }

      
    }
}
