using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private Board b;

        public Form1()
        {
            InitializeComponent();
            this.b = new Board(4, 4);
        }

        private void btn_StartSnake_Click(object sender, EventArgs e)
        {
            Snake s = new Snake(b);
            TraverseDown(s);
        }

        //traverse GRID until bottom node
        private void TraverseDown(Snake s)
        {
            //if below node is not empty move down
            if (s.MoveDown() != null)
            {
                //calls the downward traversal recursively
                TraverseDown(s);
                //lbl_NodesVisitedCount.Text = s.Count.ToString();
                //lbl_NodesVisitedCount.Text = s.Path1.Count.ToString();
                lbl_CurrentNode.Text = "Finished on node: [" + s.Position.Column.ToString() + ", " + s.Position.Row.ToString() + "]";
            }

            else
            { 
                //If right node is not null take a step to the right AND traverse up
                if (s.MoveRight() != null)
                {
                    TraverseUp(s);
                    //lbl_NodesVisitedCount.Text = s.Count.ToString();
                    //lbl_NodesVisitedCount.Text = s.Path1.Count.ToString();
                    lbl_CurrentNode.Text = "Finished on node: [" + s.Position.Column.ToString() + ", " + s.Position.Row.ToString() + "]";
                }
                
                //If move up is possible Traverse UP
                else if (s.MoveUp() != null)
                {
                    TraverseUp(s);
                    //lbl_NodesVisitedCount.Text = s.Count.ToString();
                    //lbl_NodesVisitedCount.Text = s.Path1.Count.ToString();
                    lbl_CurrentNode.Text = "Finished on node:  [" + s.Position.Column.ToString() + ", " + s.Position.Row.ToString() + "]";
                }

                else
                {
                    BackTrack(s);
                    PrintPaths(s);
                }
            }
        }

        //Traverse up until top node
        private void TraverseUp(Snake s)
        {
            //if move up is possible
            if (s.MoveUp() != null)
            {
                //calls the upward traversal recuresively
                TraverseUp(s);
                //lbl_NodesVisitedCount.Text = s.Count.ToString();
                //lbl_NodesVisitedCount.Text = s.Path1.Count.ToString();
                lbl_CurrentNode.Text = "[" + s.Position.Column.ToString() + ", " + s.Position.Row.ToString() + "]";
            }

            else
            {
                //take a step to the right and traverse down
                if(s.MoveRight() != null)
                {
                    TraverseDown(s);
                    //lbl_NodesVisitedCount.Text = s.Count.ToString();
                    //lbl_NodesVisitedCount.Text = s.Path1.Count.ToString();
                    lbl_CurrentNode.Text = "[" + s.Position.Column.ToString() + ", " + s.Position.Row.ToString() + "]";
                }
                
                //Take a step left and traverse down
                if (s.MoveLeft() != null)
                {
                    TraverseDown(s);
                    //lbl_NodesVisitedCount.Text = s.Count.ToString();
                    //lbl_NodesVisitedCount.Text = s.Path1.Count.ToString();
                    lbl_CurrentNode.Text = "[" + s.Position.Column.ToString() + ", " + s.Position.Row.ToString() + "]";
                }

                //else
                //{
                //    BackTrack(s);
                //    PrintPaths(s);
                //}
            }
        }

        private void BackTrack(Snake s)
        {
            foreach (Node n in s.Path1)
            {
                //if the neighbors of node are not flagged add node to my_Path2
                if (n.Left == s.Flag.First.Value && n.Left != null || n.Right == s.Flag.First.Value && n.Right != null ||
                    n.Above == s.Flag.First.Value && n.Above != null || n.Below == s.Flag.First.Value && n.Below != null)
                {
                    s.Path2.AddLast(n);
                    s.Position = s.Flag.Last.Value;
                    s.Path2.AddLast(s.Position);
                    s.Flag.RemoveLast();
                    break;
                }

                else s.Path2.AddLast(n);
            }
        }

        private void PrintPaths(Snake s)
        {
            lbl_Path1.Text = s.Path1.Count.ToString();
            lbl_Path2.Text = s.Path2.Count.ToString(); //<-------------THIS METHOD OUTPUTS 18 INSTEAD OF 9!
        }
    }
}
