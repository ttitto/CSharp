namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;
    using System.Text;

    partial struct BinarySearchTree<T> : ICloneable, IEnumerable<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        public TreeNode<T> Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public void Add(T value)
        {
            // if the tree doesn't exist add new node as root
            if (value == null) throw new ArgumentNullException("Can not add null value!");
            this.Root = AddNode(value, null, Root);
        }

        private TreeNode<T> AddNode(T value, TreeNode<T> parentNode, TreeNode<T> node)
        {
            // if the root doesn't have a node, create one
            if (node == null)
            {
                node = new TreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int comparer = value.CompareTo(node.value);

                // if the new element is smaller than the root, add the element in the left sub-tree
                if (comparer < 0) node.leftChild = AddNode(value, node, node.leftChild);

                // if the new element is bigger than the root, add the element in the right sub-tree
                else if (comparer > 0) node.rightChild = AddNode(value, node, node.rightChild);
            }
            return node;

        }
       
        public TreeNode<T> Find(T value)
        {
            //starting from the root
            TreeNode<T> node = this.Root;

            while (node != null)
            {
                //if the element is equal to the node, return it
                if (value.Equals(node.value)) return node;
                else
                {
                    int comparer = value.CompareTo(node.value);
                    //if the new element is smaller than the node, continue searching with the node's left child
                    if (comparer < 0) node = node.leftChild;
                    //if the new element is bigger than the node, continue searching with the node's right child
                    else if (comparer > 0) node = node.rightChild;
                    else break;
                }
            }

            return node;
        }
       
        public void RemoveNode(T value)
        {
            // first find the node with the given value
            TreeNode<T> node = Find(value);

            // if the node has two childs
            if (node.leftChild != null && node.rightChild != null)
            {
                TreeNode<T> minNode = Min(node.rightChild);
                node.value = minNode.value;
                node = minNode;
                // return;
            }

            // if the node doesn't have any childs, remove its parent reference to it
            if (node.leftChild == null && node.rightChild == null)
            {
                // if it has a parent, make its reference to the node==null
                if (node.parent.leftChild == node) node.parent.leftChild = null;
                else if (node.parent.rightChild == node) node.parent.rightChild = null;

                // if it has not any parent, then this is the root, remove it
                else if (node.parent == null) this.Root = null;
                return;
            }

            // if the node has only one child, check if it is left or right
            // if the child is leftChild
            if (node.leftChild != null)
            {
                node.value = node.leftChild.value;
                node.leftChild = null;
            }
            //if the child is rightChild
            else
            {
                node.value = node.rightChild.value;
                node.rightChild = null;
            }

        }
        private TreeNode<T> Min(TreeNode<T> node)
        {
            while (node.leftChild != null)
            {
                node = node.leftChild;
            }

            return node;
        }

        private IEnumerable<T> InOrderTraversal(TreeNode<T> node)
        {
            if (node != null)
            {
                // Visit node's left child
                foreach (T item in this.InOrderTraversal(node.leftChild))
                {
                    yield return item;
                }

                yield return node.value;

                //Visit node's right child
                foreach (T item in this.InOrderTraversal(node.rightChild))
                {
                    yield return item;
                }
            }
        }

        public object Clone()
        {
            BinarySearchTree<T> newTree = new BinarySearchTree<T>();
            TreeNode<T> newRoot = this.Root;

            newTree.Add(newRoot.value);
            foreach (var item in this)
            {
                newTree.Add(item);
            }

            return newTree;
        }
       
        public IEnumerator<T> GetEnumerator()
        {
            return this.InOrderTraversal(this.Root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
        public override bool Equals(object obj)
        {
            BinarySearchTree<T> other = (BinarySearchTree<T>)obj;
            for (int i = 0; i < this.Count(); i++)
            {
                if (!this.ElementAt(i).Equals(other.ElementAt(i)))
                {
                    return false;
                }
            }

            return true;
        }
       
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
      
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(this.Root);
            sb.Append(") ");
            foreach (var item in this)
            {
                if (this.Root.value.Equals(item)) continue;
                sb.Append(item);
                sb.Append(" ");
            }
            return sb.ToString();
        }
      
        public static bool operator ==(BinarySearchTree<T> first, BinarySearchTree<T> second)
        {
            return first.Equals(second);
        }
 
        public static bool operator !=(BinarySearchTree<T> first, BinarySearchTree<T> second)
        {
            return !first.Equals(second);
        }
    }
}
