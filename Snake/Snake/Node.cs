using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Node
    {
        private int my_Column;
        private int my_Row;
        private bool isPassable;
        private bool isUsed;
        private Node right;
        private Node left;
        private Node above;
        private Node below;

        public bool Passable { get { return isPassable; } }
        public bool Used { get { return isUsed; } set { isUsed = value; } }
        public int Column { get { return my_Column; } set { my_Column = value; } }
        public int Row { get { return my_Row; } set { my_Row = value; } }
        public Node Right { get { return right; } }
        public Node Left { get { return left; } }
        public Node Above { get { return above; } }
        public Node Below { get { return below; } }

        //Constructor
        public Node(int i, int j, bool passable)
        {
            this.my_Column = i;
            this.my_Row = j;
            this.isPassable = passable;
            this.right = null;
            this.left = null;
            this.above = null;
            this.below = null;
        }

        //Node checks
        public bool CheckPassableUsedStatus(Node n)
        {
            if (n.isPassable == true && n.isUsed == false && n != null)
            {
                return true;
            }
            else return false;
        }
        public bool CheckBounds(int bounds)
        {
            if (bounds >= 0 && bounds < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Neighboring node logic
        public void GetAboveNode(Node current_Node, ref Node above_Node)
        {

            //as long as the above node is not null
            if (above_Node != null) 
            {
                //the above neighbor is above_Node
                current_Node.above = above_Node;
            }
            else return;
        }
        public void GetBelowNode(Node current_Node, ref Node below_Node)
        {
            //as long as the above node is not null
            if (below_Node != null)
            {
                //the above neighbor is above_Node
                current_Node.below = below_Node;
            }
            else return;
        }
        public void GetRightNode(Node current_Node, ref Node right_Node)
        {
            //as long as the above node is not null
            if (right_Node != null)
            {
                //the above neighbor is above_Node
                current_Node.right = right_Node;
            }
            else return;
        }
        public void GetLeftNode(Node current_Node, ref Node left_Node)
        {
            //as long as the above node is not null
            if (left_Node != null)
            {
                //the above neighbor is above_Node
                current_Node.left = left_Node;
            }
            else return;
        }
    }
}
