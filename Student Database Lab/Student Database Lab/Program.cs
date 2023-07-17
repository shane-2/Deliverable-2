using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Threading.Tasks;

//create arrays
string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] towns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "Poughkeepsie", "West bloomfield", "Rochester Hills", "Clio", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };
 
//Get user input
bool runProgram = true;
while (runProgram)
{
    int input = 0;
    int t = 0;
        while (t == 0)
    {
        int s = 0;
        while (s == 0)
        {


            Console.WriteLine("Would you like to see a list of students?y/n");
            string yesNo = Console.ReadLine();
            if (yesNo == "y")
            {
                foreach (string n in names)
                {
                    Console.WriteLine(n);
                }
                s++;
            }
            else if (yesNo == "n")
            {

                s++;

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        Console.WriteLine("Please select a student via number 1-11");
        input = int.Parse(Console.ReadLine());
        if (input <= 0 || input > 11)
        {
            Console.WriteLine("Only number 1-11 please!");

        }
        else
        {
            t++;
        }
    }
Console.WriteLine(names[input - 1]);
    int p = 0;
    while (p == 0)
    {
Console.WriteLine("Type Hometown to learn their Hometown or type favorite food to learn their favorite food");
string townFood = Console.ReadLine();
string finalAnswer = townFood.ToLower().Trim();

        

        if ((finalAnswer.Contains("town")) == true)
        {
            Console.WriteLine($"Home Town is {towns[input -1]}");
            
            p++;
        }
        else if (finalAnswer.Contains("food") == true)
        {
            Console.WriteLine($"Favorite Food is {foods[input -1]}");
            
            p++;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
int x = 0;
    while (x == 0)
    {


        Console.WriteLine("Would you like to learn about another student? y/n");
        string yesNo = Console.ReadLine();
        if (yesNo == "y")
        {
            runProgram = true;
            x++;
        }
        else if (yesNo == "n")
        {
            runProgram = false;
            break;

        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
