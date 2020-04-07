using System;

namespace Password_retry
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "Hey Raam Hey Raam";
            

            for (int attemptsRemaining=3; attemptsRemaining >0; attemptsRemaining-- )
            {
                Console.WriteLine($"Please enter the correct password. You can try {attemptsRemaining} times." );
                string password = Console.ReadLine();
                if (password == correctPassword) {
                    Console.WriteLine("Congratulations. You entered the right password");
                    break;
                }

                if (attemptsRemaining <= 1)
                {
                    Console.WriteLine("You password did not match You have already entered 3 incorrect passwords.");
                }
                else
                {
                    Console.WriteLine("Your password did not match");
                }
                    
                    
                  
                
                

               

            }

           

            }

        }
    }

