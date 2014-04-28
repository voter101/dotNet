using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad2
{
    class BinaryTreeNode<T>: IEnumerable<T> where T: IComparable<T> 
    {
        public T data { get; set; }
        public BinaryTreeNode<T> leftNode { get; set; }
        public BinaryTreeNode<T> rightNode { get; set; }

        public BinaryTreeNode(T value)
        {
            this.data = value;
            this.leftNode = null;
            this.rightNode = null;

        }

        public void insert(T value)
        {
            T currentValue = this.data;

            if (value.CompareTo(currentValue) <= 0)
            {
                if (this.leftNode == null)
                {
                    this.leftNode = new BinaryTreeNode<T>(value);
                }
                else
                {
                    this.leftNode.insert(value);
                }
            }
            else
            {
                if (this.rightNode == null)
                {
                    this.rightNode = new BinaryTreeNode<T>(value);
                }
                else
                {
                    this.rightNode.insert(value);
                }
            }
        }

        public string przejscie()
        {
            string tree = "";
            if (this.leftNode != null)
            {
                tree = tree + this.leftNode.przejscie();
            }
            tree = tree + string.Format("{0}, ", this.data);
            if (this.rightNode != null)
            {
                tree = tree + this.rightNode.przejscie();
            }
            return tree;
        }







        //enumerable bez yield 
        /*
        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new TreeEnumeratorBFS<T>(this);
        }

        #endregion
        */



        /*

        // enumerable z uzyciem yield dfs
        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            if (this.leftNode != null)
            {
                foreach (T item in this.leftNode)
                {
                    yield return item;
                }
            }
            yield return this.data;

            if (this.rightNode != null)
            {
                foreach (T item in this.rightNode)
                {
                    yield return item;
                }
            }
        }
        #endregion
        */



        //enumerable z uzyciem yield bfs
        
        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
           Queue<BinaryTreeNode<T>> tempQueue = new Queue<BinaryTreeNode<T>>();
            tempQueue.Enqueue(this);
            while (true)
            {
                BinaryTreeNode<T> tempNode = tempQueue.Dequeue();
                yield return tempNode.data;
                if (tempNode.leftNode != null)
                {
                    tempQueue.Enqueue(tempNode.leftNode);
                }
                if (tempNode.rightNode != null)
                {
                    tempQueue.Enqueue(tempNode.rightNode);
                }
                if (tempQueue.Count == 0)
                {
                    break;
                }
            }
        }

        #endregion
        




        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
