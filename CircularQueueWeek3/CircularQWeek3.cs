using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularQueueWeek3
{
    public class CircularQWeek3
    {
        private int _head;
        private int _tail;
        public int capacity;

        private int _counter;
        private int[] _buffer;

        private const double LOWER_THRESHOLD = 0.66;

        public CircularQWeek3(int capacity)
        {
            _tail = -1;
            _head = 0;
            this.capacity = capacity;
            _buffer = new int[capacity];
        }


        public void Log(int number)
        {
            if (_counter == capacity)
            {
                // Ganti dengan mengisi oldest data
                _buffer[_head] = number;
                Console.WriteLine($"Overwritten oldest with [{number}]");
                // geser
                _head = (_head + 1) % capacity;

                // tail geser ke yang baru
                _tail = (_tail + 1) % capacity;


                // Console.WriteLine("Buffer Full");
                return;
            }
            // add to array
            _counter++;
            _tail = (_tail + 1) % capacity;
            _buffer[_tail] = number;

            // Console.WriteLine($"Tail : {_tail}");
            Console.WriteLine($"Logged [{number}]");

            if (_counter == capacity)
            {
                Console.WriteLine("Critical: Buffer Full");
                return;
            }

            if (_counter >= capacity*LOWER_THRESHOLD)
            {
                Console.WriteLine("Buffer at 66%");
            }
            //  Console.WriteLine("===========");
        }

        public void Read()
        {

            if (_counter == 0)
            {
                Console.WriteLine("EMPTY");
                return;
            }
            int headVal = _buffer[_head];
            Console.WriteLine($"Read [{headVal}]");
            _buffer[_head] = 0;
            _counter--;

            _head = (_head + 1) % capacity;
            // Console.WriteLine($"Head : {_head}");
            // Console.WriteLine("===========");
        }

    }
}
