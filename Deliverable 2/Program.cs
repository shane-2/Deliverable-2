// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    {
        Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string answer = Console.ReadLine().ToLower();
        if (answer == "no")
        {
            Console.WriteLine("You are a coward " + name + ".");
        }

        Random coin = new Random();
        int compflip = coin.Next(0, 2);
        string[] choices = { "Heads", "Tails" };
        if (answer == "yes")
        {
            int x = 0;
            //count how many times console said "Correct!"
            { for (int i = 0; i < 5; i++)


                    
                { 

                Console.WriteLine("Heads or Tails?");
                    {
                        
                        bool playerwins = true;
                        


                        playerwins = (Console.ReadLine() == choices[compflip]);
                        {
                            if (!playerwins)

                                


                            {
                                Console.WriteLine("Correct!");
                                compflip = coin.Next(0, 2);
                                x++;


                            }
                            else
                            {
                                Console.WriteLine("Wrong!");
                                compflip = coin.Next(0, 2);
                            }
                        }
                        
                    }
                }
               
            }
            Console.WriteLine("Thank you " + name + " you got a score of " + x + "!");

        }
        
    }
}