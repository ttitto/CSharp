using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTreeTestClass
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> myTree = new BinarySearchTree<int>();

            myTree.Add(86);
            myTree.Add(12);
            myTree.Add(45);
            myTree.Add(34);
            myTree.Add(100);
            myTree.Add(89);
            myTree.Add(14);
            myTree.Add(55);

            myTree.Find(34);

            // myTree.RemoveNode(45);
            // myTree.RemoveNode(34);
            myTree.RemoveNode(89);

            foreach (var item in myTree)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            BinarySearchTree<int> myNewTree = (BinarySearchTree<int>)myTree.Clone();

            myTree.Root.value = 87;
            foreach (var item in myNewTree)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in myTree)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myTree.Equals(myNewTree));
            Console.WriteLine(myNewTree.ToString());
            Console.WriteLine(myNewTree == myTree);
            Console.WriteLine(myNewTree != myTree);
            Console.WriteLine(myTree.GetHashCode());

        }
    }
}
