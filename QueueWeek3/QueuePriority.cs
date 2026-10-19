using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueWeek3
{
    public class QueuePriority
    {
        public QueuePriority(char lttr, int p)
        {
            letter = lttr;
            priority = p;
        }

        public char letter {get;}
        public int priority {get;}

        
    }
}