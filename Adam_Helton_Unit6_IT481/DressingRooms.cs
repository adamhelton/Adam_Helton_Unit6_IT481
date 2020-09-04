using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Adam_Helton_Unit6_IT481
{
    public class DressingRooms
    {
         private int rooms;
         private Semaphore semaphore;
         private long waitTimer;
         private long runTimer;

        public DressingRooms()
        {
            rooms = 3;
            semaphore = new Semaphore(rooms, rooms);
        }

        public DressingRooms(int r)
        {
            rooms = r;
            semaphore = new Semaphore(rooms, rooms);
        }

        public async Task RequestRoom(Customer c)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Customer is Waiting");
            stopwatch.Start();
            semaphore.WaitOne();
            stopwatch.Stop();
            waitTimer += stopwatch.ElapsedTicks;

            int roomWaitTime = GetRandomNumber(1, 3);
            stopwatch.Start();
            Thread.Sleep(roomWaitTime * c.getNumberOfItems());
            stopwatch.Stop();
            runTimer += stopwatch.ElapsedTicks;

            Console.WriteLine("Customer finished trying on items in room");
            semaphore.Release();
        }

        public long getWaitTime()
        {
            return waitTimer;
        }

        public long getRunTime()
        {
            return runTimer;
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