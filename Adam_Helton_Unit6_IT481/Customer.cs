using System;

namespace Adam_Helton_Unit6_IT481
{
    class Customer
    {
        private int NumberOfItems;

        public Customer()
        {
            NumberOfItems = 6;
        }

        public Customer(int items)
        {
            int ClothingItems = items;
            if (ClothingItems == 0)
            {
                NumberOfItems = GetRandomNumber(1, 20);
            }
            else
            {
                NumberOfItems = ClothingItems;
            }
        }

        private static readonly Random getRandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getRandom)
            {
                return getRandom.Next(min, max);
            }
        }

        
    }
}