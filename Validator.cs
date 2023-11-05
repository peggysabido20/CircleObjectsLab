using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    public class Validator
    {
        public static bool wantToContinue()
        {
            while (true)
            {
                Console.Write("Would you like to order anything else (y/n)? ");
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer) && (answer.Trim().ToLower() == "n" || answer.Trim().ToLower() == "y"))
                {
                    return (answer.Trim().ToLower() == "y");
                }
                Console.Write("Invalid entry, please enter y/n. Press any key .....");
                string AnyKey = Console.ReadLine();
            }
        }

        public static double validDouble(string userEntry)
        {
            try
            {
                double num = double.Parse(userEntry);
                return num;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + "Try again.");
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
