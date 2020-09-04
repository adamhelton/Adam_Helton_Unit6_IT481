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
            Thread.Sleep(roomWaitTime * getNumerOfItems());
            stopwatch.Stop();
            runTimer += stopwatch.ElapsedTicks;
        }
    }
}