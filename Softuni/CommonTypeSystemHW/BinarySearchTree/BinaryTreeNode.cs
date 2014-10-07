namespace BinarySearchTree
{
    using System;

    partial struct BinarySearchTree<T> where T : IComparable<T>
    {
        internal class TreeNode<T> : IComparable<TreeNode<T>> where T : IComparable<T>
        {
            internal T value;
            internal TreeNode<T> leftChild;
            internal TreeNode<T> rightChild;
            internal TreeNode<T> parent;

            public TreeNode(T value)
            {
                this.value = value;
                this.leftChild = null;
                this.rightChild = null;
                this.parent = null;
            }

            public override bool Equals(object obj)
            {
                TreeNode<T> other = obj as TreeNode<T>;
                if (other == null) throw new ArgumentNullException("Can not compare a null BinaryTreeNode!");
                else if (this.CompareTo(other) == 0) return true;
                else return false;
            }

            public override string ToString()
            {
                return this.value.ToString();
            }

            public override int GetHashCode()
            {
                return this.value.GetHashCode();
            }

            public int CompareTo(TreeNode<T> other)
            {
                if (this.value.CompareTo(other.value) < 0) return -1;
                else if (this.value.CompareTo(other.value) > 0) return 1;
                else return 0;
            }
        }
    }
}
