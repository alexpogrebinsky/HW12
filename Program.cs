using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {


        static void Main(string[] args)
        {string UserText, reverseText = "";
            try
            {
                do
                {
                    
                    
                    Console.WriteLine("Please enter a text to see if it is a palindrome or enter 'Exit' to leave:");
                    UserText = Console.ReadLine();

                    if (UserText == "Exit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Congrats it is a Palindrome!");
                        reverseTextCheck();
                        
                    }

                }
                while (true);
                
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured");
            }




            Console.ReadLine();
            Console.ReadKey();

        }




        static void reverseTextCheck()
        {

            string UserText, reverseText = "";
            int Length;
        
            Console.WriteLine("Please enter a text to see if it is a palindrome or enter 'Exit' to leave:");
             UserText = Console.ReadLine();

            Length = UserText.Length - 1;
            while (Length >= 0)
            {
                reverseText = reverseText + UserText[Length];
                Length--;
            }

        Console.WriteLine("Reverse is {0}", reverseText);

            if
                (reverseText == UserText)
            {
                Console.WriteLine("Congrats " + reverseText + " is a Palindrome!"); }
              
           
            else
            {
                Console.WriteLine("Sorry it is not a Palindrome!");
            }
        }
    }
}
