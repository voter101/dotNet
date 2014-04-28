using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad2
{
    class TreeEnumeratorDFS<T> : IEnumerator<T> where T: IComparable<T>
    {
        private BinaryTreeNode<T> currentData = null;
        private T currentItem = default(T);
        private Queue<T> enumData = null;

        public TreeEnumeratorDFS(BinaryTreeNode<T> data)
        {
            this.currentData = data;
        }

        public void kolejkowanie(Queue<T> enumQueue, BinaryTreeNode<T> tree)
        {
            if (tree.leftNode != null)
            {
                kolejkowanie(enumQueue, tree.leftNode);
            }
            enumQueue.Enqueue(tree.data);

            if (tree.rightNode != null)
            {
                kolejkowanie(enumQueue, tree.rightNode);
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
            get {
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
