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
    }
}