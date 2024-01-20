using System;
using System.Collections.Generic;

namespace TreeVisualizer
{
    public interface ITree
    {
        IEnumerable<NodeInfo> GetAllNodes();

        TreeConfiguration GetConfiguration();
    }

    public interface ITree<TValue> : ITree where TValue : IComparable<TValue>
    {
        void Insert(TValue value);

        void Remove(TValue value);

        void Insert0(TValue value);

        void Remove0(TValue value);

        IEnumerable<NodeInfo> SearchOut(TValue value);

        bool Find(TValue value);

    }
}
