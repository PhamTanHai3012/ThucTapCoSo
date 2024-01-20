namespace TreeVisualizer
{
    public class NodeInfo
    {
        public string Value { get; set; }

        public int Height { get; set; }

        public bool FindOut { get; set; }

        public bool UBNode { get; set; }

        public bool IsLeaf { get; set; }

        public bool IsLeftChild { get; set; }

        public bool IsRightChild { get; set; }

        public Position Position { get; set; }

        public Position LeftChildPosition { get; set; }

        public Position RightChildPosition { get; set; }
    }
}
