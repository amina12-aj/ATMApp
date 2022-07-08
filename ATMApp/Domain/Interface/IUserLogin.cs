using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Domain.Interface
{
    public interface IUserLogin
    {
        public void CheckUserCardNumberAndPassword();
    }
}
