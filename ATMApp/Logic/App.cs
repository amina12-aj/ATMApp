using System;
using System.Collections.Generic;
using ATMApp.Domain.entity;
using ATMApp.Domain.Interface;
using ATMApp.UI;

namespace ATMApp
{
   public class ATMApp:IUserLogin


    {
       public List<UserAccount> UserAccountList;
        //private readonly UserAccount SelectedAccount;

        //this is initializing the list that will hold the different account details
        private void UserList()
        {
            List<UserAccount> UserAccountList = new List<UserAccount>
            {new UserAccount {Id=1, FullName ="Amina Bakare", AccountNumber = 123456,CardNumber= 6234, CardPin = 2570, AccountBalance = 300000.00m, Islocked = false },
            new UserAccount {Id=2, FullName ="Obuse Samuel", AccountNumber = 654243, CardNumber= 6234, CardPin = 5420, AccountBalance = 300000.00m, Islocked = false },
            new UserAccount {Id=3, FullName="Oluchi Hope", AccountNumber = 352432, CardNumber= 6234, CardPin = 6025, AccountBalance = 300000.00m, Islocked = false }
            };

 UserAccountList.Add(new UserAccount { Id = 4, FullName = "Amina Riat", AccountNumber = 123756, CardNumber = 6230, CardPin = 2567, AccountBalance = 400000.00m, Islocked = false }); }
        

        public void CheckUserCardNumberAndPassword()
        {
           //bool IsNotCorrect = false;
            UserAccount TestUserAccount = new UserAccount();
            TestUserAccount.CardNumber = Validation.ValidateInput<long>("Enter your Card Number");
            TestUserAccount.CardPin = Convert.ToInt32(UsersTask.GetSecretPin("Enter your card pin"));

        }
   }
}
