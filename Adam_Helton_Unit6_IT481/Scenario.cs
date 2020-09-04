using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Adam_Helton_Unit6_IT481
{
    public class Scenario
    {
        private static Customer cust;
        private static int items = 0;
        private static int numberOfItems;
        private static int controlItemNumber;

        public Scenario(int r, int c)
        {
            Console.WriteLine(r + "dressing rooms " + " for " + c + " customers");

            controlItemNumber = 0;
            numberOfItems = 0;
        }

        static void Main(string[] args)
        {
            Console.Write("What Clothing Items value do you want? (0 = Random)");
            controlItemNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many customers do you want?");
            int numberOfCustomers = Int32.Parse(Console.ReadLine());
            Console.WriteLine("There are " + numberOfCustomers + " total customers");

            Console.WriteLine("How many dressing rooms do you want?");
            int totalRooms = Int32.Parse(Console.ReadLine());

            Scenario s = new Scenario(totalRooms, numberOfCustomers);
            
            DressingRooms dr = new DressingRooms(totalRooms);
            
            List<Task> tasks = new List<Task>();
        }
    }
}