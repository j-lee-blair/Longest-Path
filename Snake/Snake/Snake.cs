using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        private Node my_position;
        private Board my_Board;
        private int my_NodesVisitedCount;
        LinkedList<Node> my_Path1, my_Path2, my_flags;

        public LinkedList<Node> Path2 { get { return my_Path2; } set { my_Path2 = value; } }
        public LinkedList<Node> Path1{ get { return my_Path1; }}
        public LinkedList<Node> Flag { get { return my_flags; } }
        
        public Node Position { get { return my_position; } set { value = my_position; } }
        public int Count { get { return my_NodesVisitedCount; } }

        public Snake(Board b)
        {
            this.my_Board = b;
            this.my_NodesVisitedCount = 0;
            this.my_Path1 = new LinkedList<Node>();
            this.my_Path2 = new LinkedList<Node>();
            this.my_flags = new LinkedList<Node>();
            this.my_position = b.Array[0, 0]; //starting position
        }

        //These may be default methods for LinkedList class so may need to be deleted as they may be obselete
        private void AddToPath1(Node n)
        {
            if (n != null)
            {
                my_Path1.AddLast(n);
            }
        }
        private void AddToPath2(Node n)
        {
            if (n != null)
            {
                my_Path2.AddLast(n);
            }
        }

        //Flags unvisited nodes
        private void PlaceFlag(Node position)
        {
            if (position.Left != null && position.Left.Used == false && position.Left.Passable == true)
            {
                my_flags.AddLast(position.Left);
            }
            else return;
        }

        //validate moves
        private bool MoveCheckDown(Node position)
        {
            //To move up the snake is already on the max boundary and therefore does not move up
            if ((my_Board.CheckMaxBounds(my_position.Row)))
            {
                //If the position has not been used AND is passable
                if (position.CheckPassableUsedStatus(position))
                {
                    AddToPath1(position);

                    //if right neighbor of the starting node is not empty or inpassable
                    //PlaceFlag(position);
                    return true;
                }
                //Boundary fail check / null object
                return false;
            }
            //Boundary fail check
            return false;
        }
        private bool MoveCheckRight(Node position)
        {
            if ((my_Board.CheckMaxBounds(my_position.Column)))
            {
                //If the position has not been used AND is passable
                if (position.CheckPassableUsedStatus(position))
                {
                    AddToPath1(position);

                    //if right neighbor of the starting node (above node.Right) is not empty or inpassable
                    //PlaceFlag(position);
                    return true;
                }
                //Boundary fail check
                return false;
            }
            //Boundary fail check
            return false;
        }
        private bool MoveCheckLeft(Node position)
        {
            if ((my_Board.CheckMinBounds(my_position.Column)))
            {
                //If the position has not been used AND is passable
                if (position.CheckPassableUsedStatus(position))
                {
                    AddToPath1(position);

                    //if right neighbor of the starting node (above node.Right) is not empty or inpassable
                    //PlaceFlag(position);
                    return true;
                }
                //Boundary fail check
                return false;
            }
            //Boundary fail check
            return false;
        }
        private bool MoveCheckUp(Node position)
        {
            //To move up the snake is already on the max boundary and therefore does not move up
            if ((my_Board.CheckMinBounds(my_position.Row)))
            {
                //If the position has not been used AND is passable
                if (position.CheckPassableUsedStatus(position))
                {
                    AddToPath1(position);

                    //if right neighbor of the starting node is not empty or inpassable
                    //PlaceFlag(position);
                    return true;
                }
                //Boundary fail check / null object
                return false;
            }
            //Boundary fail check
            return false;
        }

        //Snake Movers
        public Node MoveUp()
        {
            if (MoveCheckUp(my_position.Above))
            {
                //Move taken
                my_position = my_position.Above;

                PlaceFlag(my_position);
                my_NodesVisitedCount ++;
                my_position.Used = true;
                return my_position;
            }
                //No move taken
            else return null;
        }
        public Node MoveDown()
        {
            if (MoveCheckDown(my_position.Below))
            {
                //Move taken
                my_position = my_position.Below;

                PlaceFlag(my_position);
                my_NodesVisitedCount++;
                my_position.Used = true;
                return my_position;

            }
                //No move taken
            else return null;
        }
        public Node MoveLeft()
        {
            if (MoveCheckLeft(my_position.Left))
            {
                //Move taken
                my_position = my_position.Left;

                PlaceFlag(my_position);
                my_NodesVisitedCount++;
                my_position.Used = true;
                return my_position;
            }
                //No move taken
            else return null;
        }
        public Node MoveRight()
        {
            if (MoveCheckRight(my_position.Right)) //when moving right you only need to check the columns not the rows!
            {
                //Move taken
                my_position = my_position.Right;

                PlaceFlag(my_position);
                my_NodesVisitedCount++;
                my_position.Used = true;
                return my_position;
            }
            
            //No move taken
            else return null;
        }
        public Node RePositionSnake(Node new_Position)
        {
            this.my_position = new_Position;
            AddToPath1(my_position);
            my_NodesVisitedCount++;
            return my_position;
        }
    }
}
