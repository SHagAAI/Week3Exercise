using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedListWeek3
{


    public class CustomNode
    {
        public int myNum { get; set; }
        public static CustomNode? head { get; set; }
        public CustomNode? tail { get; set; }

        public CustomNode? prev;

    }
}

