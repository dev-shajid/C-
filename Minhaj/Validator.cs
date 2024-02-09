using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{
    public static class Validator
    {
        public static T Converter<T>(string input)
        {
            bool success = false;
            string userInput ="";

            while (!success)
            {
                userInput = Utility.Getuserin(input);

                try
                {
                    //here typedescriptor is a class which is used to convert the string to the type of the class.it is a generic class
                    //here we are using the getconverter method to convert the string to the type of the class
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    string Box = "Invalid input, please try again.";
                    //Console.WriteLine("Invalid input, please try again.");
                   
                    Utility.printmassage(Box, false);
                   
                }
                
               
            }
            return default;
        }
    }
}
