using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeVisualizer
{
    public class AVLTree<TValue> : BaseTree<TValue> where TValue : IComparable<TValue>
    {
        public Node<TValue> _root;
        public AVLTree(TreeConfiguration configuration): base(configuration)
        {
            _configuration = configuration;
        }

        public override void Insert(TValue value)
        {
            _root = Insert(_root, value);
        }

        public override void Remove(TValue value)
        {
            _root = Remove(_root, value);
        }

        public override void Insert0(TValue value)
        {
            _root = Insert0(_root, value);
        }

        public override void Remove0(TValue value)
        {
            _root = Remove0(_root, value);
        }

        public override IEnumerable<NodeInfo> SearchOut(TValue value)
        {
            return SearchOut(GetAllNodes(), value);
        }

        public override bool Find(TValue value)
        {
            return Find(_root, value);
        }

        private Node<TValue> Insert(Node<TValue> root, TValue value)
        {
            if (root == null)
                root = new Node<TValue>(value);

            else if (root.Value.CompareTo(value) > 0)
            {
                root.Left = Insert(root.Left, value);
                root = BalanceTree(root);
            }
            else
            {
                root.Right = Insert(root.Right, value);
                root = BalanceTree(root);
            }
            return root;
        }

        private Node<TValue> Insert0(Node<TValue> root, TValue value)
        {
            if (root == null)
                root = new Node<TValue>(value);

            else if (root.Value.CompareTo(value) > 0)
            {
                root.Left = Insert0(root.Left, value);
            }
            else
            {
                root.Right = Insert0(root.Right, value);
            }
            return root;
        }

        private Node<TValue> Remove(Node<TValue> root, TValue value)
        {
            if (root == null)
                return root;

            if (root.Value.CompareTo(value) > 0)
            {
                root.Left = Remove(root.Left, value);
                root = BalanceTree(root);
            }
            else if (root.Value.CompareTo(value) < 0)
            {
                root.Right = Remove(root.Right, value);
                root = BalanceTree(root);
            }
            else
            {
                Node<TValue> parent;
                if (root.Right != null)
                {
                    parent = root.Right;
                    while (parent.Left != null)
                    {
                        parent = parent.Left;
                    }
                    root.Value = parent.Value;
                    root.Right = Remove(root.Right, parent.Value);
                    root = BalanceTree(root);
                }
                else
                    return root.Left;
            }
            return root;
        }

        private Node<TValue> Remove0(Node<TValue> root, TValue value)
        {
            if (root == null)
                return root;

            if (root.Value.CompareTo(value) > 0)
            {
                root.Left = Remove0(root.Left, value);
            }
            else if (root.Value.CompareTo(value) < 0)
            {
                root.Right = Remove0(root.Right, value);
            }
            else
            {
                Node<TValue> parent;
                if (root.Right != null)
                {
                    parent = root.Right;
                    while (parent.Left != null)
                    {
                        parent = parent.Left;
                    }
                    root.Value = parent.Value;
                    root.Right = Remove(root.Right, parent.Value);
                }
                else
                    return root.Left;
            }
            return root;
        }

        private bool Find(Node<TValue> root, TValue value)
        {
            if (root == null) return false;

            if (root.Value.CompareTo(value) > 0)
            {
                return Find(root.Left, value);
            }
            else if (root.Value.CompareTo(value) < 0)
            {
                return Find(root.Right, value);
            }
            else return true;
        }

        public Node<TValue> Copy(Node<TValue> tree1, Node<TValue> tree2)
        {
            if (tree2 == null) return null;

            tree1 = new Node<TValue>(tree2.Value);

            tree1.Left = Copy(tree1.Left, tree2.Left);

            tree1.Right = Copy(tree1.Right, tree2.Right);

            return tree1;
        }
        private IEnumerable<NodeInfo> SearchOut(IEnumerable<NodeInfo> nodeInfos, TValue value)
        {
            foreach (var nodeInfo in nodeInfos)
            {
                if (nodeInfo.Value == value.ToString())
                {
                    nodeInfo.FindOut = true;
                }
                else
                {
                    nodeInfo.FindOut = false;
                }
            }
            return nodeInfos;
        }

        public override IEnumerable<NodeInfo> GetAllNodes()
        {
            var nodeCollection = new List<Node<TValue>>();

            GetAllNodes(_root, nodeCollection);

            var nodeInfos = nodeCollection.ToDictionary(
                x => x,
                y => new NodeInfo
                {
                    Value = y.Value.ToString(),
                    IsLeaf = y.Left == null && y.Right == null
                }
            );

            CalculateNodePositions(_root, nodeInfos, offset: 0, depth: 0);
            AggregateChildNotePositions(_root, null, nodeInfos);

            foreach (var node in nodeCollection)
            {
                nodeInfos[node].Height = GetHeight(node);
                if (GetBalanceFactor(node) < -1 || GetBalanceFactor(node) > 1)
                {
                    nodeInfos[node].UBNode = true;
                }
                else nodeInfos[node].UBNode = false;
            }
            return nodeInfos.Values;
        }

        private Node<TValue> BalanceTree(Node<TValue> root)
        {
            int balanceFactor = GetBalanceFactor(root);
            if (balanceFactor > 1)
            {
                if (GetBalanceFactor(root.Left) > 0)
                    root = RotateLL(root);
                else
                    root = RotateLR(root);
            }
            else if (balanceFactor < -1)
            {
                if (GetBalanceFactor(root.Right) > 0)
                    root = RotateRL(root);
                else
                    root = RotateRR(root);
            }
            return root;
        }

        private int GetBalanceFactor(Node<TValue> root)
        {
            int left = GetHeight(root.Left);
            int right = GetHeight(root.Right);
            int factor = left - right;
            return factor;
        }   

        private int GetHeight(Node<TValue> root)
        {
            int height = 0;
            if (root != null)
            {
                int left = GetHeight(root.Left);
                int right = GetHeight(root.Right);
                int max = GetMax(left, right);
                height = max + 1;
            }
            return height;
        }

        private int GetMax(int left, int right)
        {
            return left > right ? left : right;
        }

        private Node<TValue> RotateRR(Node<TValue> parent)
        {
            Node<TValue> pivot = parent.Right;
            parent.Right = pivot.Left;
            pivot.Left = parent;
            return pivot;
        }

        private Node<TValue> RotateLL(Node<TValue> parent)
        {
            Node<TValue> pivot = parent.Left;
            parent.Left = pivot.Right;
            pivot.Right = parent;
            return pivot;
        }

        private Node<TValue> RotateLR(Node<TValue> parent)
        {
            Node<TValue> pivot = parent.Left;
            parent.Left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private Node<TValue> RotateRL(Node<TValue> parent)
        {
            Node<TValue> pivot = parent.Right;
            parent.Right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
