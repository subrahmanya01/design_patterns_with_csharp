namespace Structural.Composite
{
    internal class CompositeNode : Node
    {
        private readonly List<Node> _children = new();

        public CompositeNode(string name) : base(name)
        {
        }

        public CompositeNode(string name, string id) : base(name, id)
        {
        }

        public override void AddNode(Node node)
        {
            node.SetParent(this);
            _children.Add(node);
        }

        public override void PrintChildren()
        {
            foreach (var child in _children) { 
                Console.WriteLine($"{child.GetId()} - {child.GetName()}");
            }
        }

        public override void RemoveNode(Node node)
        {
            _children.Remove(node);
        }

        public override void RemoveNode(string id)
        {
            var node = _children.FirstOrDefault(x=> x.GetId().Equals(id));
            this.RemoveNode(node);
        }

        public void PrintParent()
        {
            Console.WriteLine($"{parentNode.GetId()} - {parentNode.GetName()}");
        }
    }
}
