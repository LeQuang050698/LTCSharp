using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace AtmApp.UI
{
    public class Validator
    {
        public static T? Convert<T>(string prompt)
        {
            bool isValid = false;
            string userInput;
            while(!isValid){
                userInput = Utility.GetUserInput(prompt);
                try
                {
                    var conventer = TypeDescriptor.GetConverter(typeof(T));
                    if(conventer != null){
                        return (T)conventer.ConvertFromString(userInput);
                    } else { return default; }
                } catch { Utility.PrintMessage("Please Re-Enter"); }
            }
            return default;
        }
    }
}