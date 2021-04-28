using System;
using System.Collections.Generic;
using System.Text;
using CHR_Interview_WebApp_Final;

namespace CHR_Interview_WebApp_Final
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public void Insert(int value, string state)
        {
            if (root != null)
            {
                root.Insert(value, state);
            }
            else
            {
                root = new TreeNode(value, state);
            }
        } //Inserts the country into the tree with its number and 3 letter state code.

        public int FindPath(int value, List<string> order) //Searches through the tree to find the correct path to the entered destination.
        {

            if (value == root.Data)
            {
                order.Add(root.Code);
                return root.Data;
            }
            else if (value < root.Data)
            {
                if (root.LeftNode == null)
                {
                    order.Add(root.Code);
                    return 0;
                }
                else
                {
                    order.Add(root.Code);
                    return root.LeftNode.FindPath(value, order);
                }
            }
            else
            {
                if (root.RightNode == null)
                {
                    order.Add(root.Code);
                    return 0;
                }
                else
                {
                    order.Add(root.Code);
                    return root.RightNode.FindPath(value, order);
                }
            }
        } 

        public static BinarySearchTree BuildTree()
        {
            BinarySearchTree countryTree = new BinarySearchTree();


            countryTree.Insert(99, "USA");
            countryTree.Insert(100, "CAN");
            countryTree.Insert(80, "MEX");
            countryTree.Insert(85, "BEL");
            countryTree.Insert(40, "GTM");
            countryTree.Insert(41, "HND");
            countryTree.Insert(1, "SLV");
            countryTree.Insert(42, "NIC");
            countryTree.Insert(43, "CRI");
            countryTree.Insert(44, "PAN");

            return countryTree;
        } //Builds the binary search tree with the countries in their places.

        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }
    }

}
