// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    {
        Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string answer = Console.ReadLine();
        if (answer == "No")
        {
            Console.WriteLine("You are a coward " + name + ".");
        }

        Random r = new Random();
        int cf = r.Next(0, 2);
        string[] ht = { "Heads", "Tails" };
        if (answer == "Yes")
        {
            int x = 0;
            //count how many times console said "Correct!"
            { for (int i = 0; i < 5; i++)


                    
                { 

                Console.WriteLine("Heads or Tails?");
                    {
                        
                        bool playerwins = true;
                        

                        playerwins = (Console.ReadLine() == ht[cf]);

                        if (!playerwins)

                        


                        {
                            Console.WriteLine("Correct!");
                            cf = r.Next(0, 2);
                            x++;
                        
                        
                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            cf = r.Next(0, 2);
                        }
                        
                    }
                }
               
            }
            Console.WriteLine("Thank you " + name + " you got a score of " + x + "!");

        }
        
    }
}