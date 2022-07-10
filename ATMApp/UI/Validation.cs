using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ATMApp.UI
{
    public static class Validation
    {
        public static T ValidateInput<T>(string prompt)
        { bool valid = true;
          string userInput;

            while (valid)
            {
                userInput = UsersTask.GetUsersInput(prompt);
                try { var Converter = TypeDescriptor.GetConverter(typeof(T));
                    if (Converter != null)
                    {
                        return (T)Converter.ConvertFromString(userInput);
                    }
                    else { return default; }
                }
                catch
                {
                    UsersTask.PrintMessage("Oops..you enter a wrong number", false);
                }
                }
            return default;
            }
            

}
    }

