using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad2
{
    class TreeEnumeratorBFS<T> : IEnumerator<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> currentData = null;
        private T currentItem = default(T);
        private Queue<T> enumData = null;

        public TreeEnumeratorBFS(BinaryTreeNode<T> data)
        {
            this.currentData = data;
        }

        public void kolejkowanie(Queue<T> enumQueue, BinaryTreeNode<T> tree)
        {
            Queue<BinaryTreeNode<T>> tempQueue = new Queue<BinaryTreeNode<T>>();
            tempQueue.Enqueue(tree);
            while (true)
            {
                BinaryTreeNode<T> tempNode = tempQueue.Dequeue();
                enumQueue.Enqueue(tempNode.data);
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

        #region IEnumerator<T> Members

        T IEnumerator<T>.Current
        {
            get
            {
                if (this.enumData == null)
                {
                    throw new InvalidOperationException("Najpierw uzyj MoveNext()");
                }
                return this.currentItem;
            }
        }

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            // throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator Members

        object System.Collections.IEnumerator.Current
        {
            get
            {
                if (this.enumData == null)
                {
                    throw new InvalidOperationException("Najpierw uzyj MoveNext()");
                }
                return this.currentItem;
            }
        }

        bool System.Collections.IEnumerator.MoveNext()
        {
            if (this.enumData == null)
            {
                this.enumData = new Queue<T>();
                kolejkowanie(this.enumData, this.currentData);
            }
            if (this.enumData.Count > 0)
            {
                this.currentItem = this.enumData.Dequeue();
                return true;
            }
            return false;
        }

        void System.Collections.IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
