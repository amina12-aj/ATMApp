using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Logic
{
    class Execution
    {
        static void Main(string[] args)
        {
            Welcome.Message();
            ATMApp atmapp = new ATMApp();
            atmapp.CheckUserCardNumberAndPin();
            //long CardNumber = Validation.ValidateInput<long>("Enter your Card Number");
            //Console.WriteLine($"Your Card Number is {CardNumber}");
            UsersTask.PressEnterToContinue();

        }
    }
}
