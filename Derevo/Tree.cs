using System;
using System.Collections.Generic;
using System.Text;

namespace Derevo
{
    class Tree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void Add(T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
            }
            else
            {
                AddRecursive(root, data);
            }
        }

        private void AddRecursive(Node<T> node, T data)
        {
            if (data.CompareTo(node.Data) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node<T>(data);
                }
                else
                {
                    AddRecursive(node.Left, data);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node<T>(data);
                }
                else
                {
                    AddRecursive(node.Right, data);
                }
            }
        }

        public Node<T> Search(T data)
        {
            return SearchRecursive(root, data);
        }

        private Node<T> SearchRecursive(Node<T> node, T data)
        {
            if (node == null || data.CompareTo(node.Data) == 0)
            {
                return node;
            }

            if (data.CompareTo(node.Data) < 0)
            {
                return SearchRecursive(node.Left, data);
            }
            else
            {
                return SearchRecursive(node.Right, data);
            }
        }
    }
}
