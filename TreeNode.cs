using System;
using System.Collections.Generic;
using System.Text;

namespace CHR_Interview_WebApp_Final
{
    public class TreeNode
    {
        private int data;
        private string code;
        private TreeNode leftNode;
        private TreeNode rightNode;


        public TreeNode(int data, string code)
        {
            this.data = data;
            this.code = code;
        }

        public int Data => data;


        public string Code => code;
   

        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        public void Insert(int value, string state)
        {
            if (value <= data)
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value, state);
                }
                else
                {
                    leftNode.Insert(value, state);
                }
            }
            else
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value, state);
                }
                else
                {
                    rightNode.Insert(value, state);
                }
            }
        } //Inserts the data into the tree. Takes the value and 3 digit state code.

        public bool Contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (leftNode == null)
                {
                    return false;
                }
                else
                {
                    return leftNode.Contains(value);
                }
            }
            else
            {
                if (rightNode == null)
                {
                    return false;
                }
                else
                {
                    return rightNode.Contains(value);
                }
            }
        } //Checks the tree for the value entered. Returns true if it is found, false otherwise.

        public int FindPath(int value, List<string> order) //Finds the path the trucker needs to take
        {

            if (value == data)
            {
                order.Add(code);
                return data;
            }
            else if (value < data)
            {
                if (leftNode == null)
                {
                    order.Add(code);
                    return 0;
                }
                else
                {
                    order.Add(code);
                    return leftNode.FindPath(value, order);
                }
            }
            else
            {
                if (rightNode == null)
                {
                    order.Add(code);
                    return 0;
                }
                else
                {
                    order.Add(code);
                    return rightNode.FindPath(value, order);
                }
            }
        }
    }



}
