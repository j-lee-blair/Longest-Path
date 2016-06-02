using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Board
    {
        int max_Columns = 0;
        int max_Rows = 0;
        Node[,] array;

        public Node[,] Array { get { return array; } }

        public Board(int column, int row)
        {
            this.max_Columns = column;
            this.max_Rows = row;
            this.array = new Node[column, row];

            //iterate through columns
            for (int i = 0; i < column; i++)
            {
                //iterate through rows
                for (int j = 0; j < row; j++)
                {
                    //if the node has the coordinates (1,1), (2,2) or (1,2) ...
                    if ((i == 1 && j == 1) || (i == 2 && j == 2) || (i == 1 && j == 2))
                    {
                        //initialize node object with false passable status.
                        array[i, j] = new Node(i, j, false);
                    }

                    else
                    {
                        //initialize default nodes.
                        array[i, j] = new Node(i, j, true);
                    }
                }
            }

            //Check bounds and pass in neighbors to GetNeighbor methods
            for (int col = 0; col < max_Columns; col++)
            {
                for (int rw = 0; rw < max_Rows; rw++)
                {
                    if (CheckMaxBounds(rw))
                    {
                        array[col, rw].GetBelowNode(array[col, rw], ref array[col, rw + 1]);
                    }

                    if (CheckMinBounds(rw))
                    {
                        array[col, rw].GetAboveNode(array[col, rw], ref array[col, rw - 1]);
                    }

                    if (CheckMaxBounds(col))
                    {
                        array[col, rw].GetRightNode(array[col, rw],ref array[col + 1, rw]);
                    }

                    if (CheckMinBounds(col))
                    {
                        array[col, rw].GetLeftNode(array[col, rw],  ref array[col - 1, rw]);
                    }
                }
            }
        }

        //Boundscheckers
        public bool CheckMaxBounds(int input)
        {
            if (input != 3)
            {
                return true;
            }
            return false;
        }
        public bool CheckMinBounds(int input)
        {
            if (input != 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckBoundsBoardCreation(int c, int r)
        {
            if ((c <= 3 && c > 0) || (r <= 3 && r > 0))
            {
                return true;
            }
            else return false;
        }
    }
}
