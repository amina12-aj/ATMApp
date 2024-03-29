﻿using System;
using System.Collections.Generic;
using System.Threading;
using ATMApp.Domain.entity;
using ATMApp.Domain.Interface;
using ATMApp.UI;

namespace ATMApp
{
    public class ATMApp : IUserLogin


    {
        public List<UserAccount> UserAccountList;
        private static UserAccount selectedAccount { get; set; }
        //this is initializing the list that will hold the different account details
       public void RegisteredAccountList()
        {
            List<UserAccount> UserAccountList = new List<UserAccount>
            {new UserAccount {Id=1, FullName ="Amina Bakare", AccountNumber = 123456,CardNumber= 6234, CardPin = 2570, AccountBalance = 300000.00m, Islocked = false },
            new UserAccount {Id=2, FullName ="Obuse Samuel", AccountNumber = 654243, CardNumber= 6234, CardPin = 5420, AccountBalance = 300000.00m, Islocked = false },
            new UserAccount {Id=3, FullName="Oluchi Hope", AccountNumber = 352432, CardNumber= 6234, CardPin = 6025, AccountBalance = 300000.00m, Islocked = true }
            };

            UserAccountList.Add(new UserAccount { Id = 4, FullName = "Amina Riat", AccountNumber = 123756, CardNumber = 6230, CardPin = 2567, AccountBalance = 400000.00m, Islocked = false });
        }


        public void CheckUserCardNumberAndPin()
        {
            bool IsCorrect = false;
            while (IsCorrect == false)
            {      //instatianting the userloginform and login progress method from the usertasks class
                UserAccount inputAccount = UsersTask.UserLoginForm();
                UsersTask.LoginProgress();
                foreach (UserAccount registeredAccount in UserAccountList)
                {
                    selectedAccount = registeredAccount;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;
                        if (inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = registeredAccount;
                            if (selectedAccount.Islocked || selectedAccount.TotalLogin > 3)
                            {
                                UsersTask.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                IsCorrect = true;
                                break;
                            }
                        }
                    }

                    if (IsCorrect == false)
                    {
                        UsersTask.PrintMessage("You entered an incorrect pin", false);
                        selectedAccount.Islocked = selectedAccount.TotalLogin == 3;
                        if (selectedAccount.Islocked)
                        {
                            UsersTask.PrintLockScreen();
                        }
                    }
                    Console.Clear();
                }
                public void Welcome()
                {
                    Console.WriteLine($"Welcome,{selectedAccount.FullName}");

                }
            }           
          
        }
    }
}
