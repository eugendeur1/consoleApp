using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A4", 280,"purple");
            audi.Drive();
            Car bmw = new Car("BMW M5",350);
            bmw.Drive();
            audi.Deatils();
            bmw.Deatils();
            
            Console.WriteLine("Input 1 to stop bmw.");
            Console.WriteLine("Input 2 to stop audi.");
            
            string userInput = Console.ReadLine();
            
            if (userInput== "1")
            {
                bmw.Stopped();
            }
            else if(userInput=="2")
            {
                audi.Stopped();
            }
            else
            {
                Console.WriteLine("Invalid number try again");
            }
            
        }
    }
}
