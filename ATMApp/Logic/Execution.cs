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
            //instanstiate the atmApp class
            ATMApp atmapp = new ATMApp();
            //calling the atmApp class method
            atmapp.CheckUserCardNumberAndPin();
            atmapp.RegisteredAccountList();
            atmapp.Welcome();
            //long CardNumber = Validation.ValidateInput<long>("Enter your Card Number");
            //Console.WriteLine($"Your Card Number is {CardNumber}");
            UsersTask.PressEnterToContinue();

        }
    }
}
