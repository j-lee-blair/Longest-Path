using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class PathTaken
    {
        private Node start = null;
        private int count = 0;
        private object temp;

        public int ReturnCount { get { return count; } }
        public object ReturnTemp { get { return temp; } }


        public void push(Node flag) //takes a Node object
        {
            if (start == null)
            {
                start = flag;
            }

            else
            {
                start = new PathTaken(dataValue, start);
            }

            Console.WriteLine("Element added to stack: " + start.my_Data.ToString());
            count = count + 1;
            Console.WriteLine("Element count: " + count);
            //            Console.WriteLine("");
        }


        public object pop()
        {
            if (start == null)
            {
                return null;
            }
            else
            {
                temp = start.my_Data; //This saves the data of the top most node before the pointer is changed 

                start = start.next_Node; //This changes the head pointer to point to the next element in the series

                count = count - 1; //This has to be placed before the return call

                return temp; //This returns the data from before the head pointer was changed.
            }
        }


        public object peek()
        {
            if (start == null)
            {
                return null;
            }

            else
            {
                return start;
            }
        }

    }
}
