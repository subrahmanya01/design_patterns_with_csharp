namespace Structural.Composite
{
    internal abstract class Node
    {
        protected string? name { get;}

        protected string id { get;}

        protected Node? parentNode { get; set; } = null;
        protected Node(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        protected Node(string name)
        {
            this.name = name;
            this.id = Guid.NewGuid().ToString();
        }

        public void SetParent(Node parent)
        {
            this.parentNode = parent;
        }

        public string GetName()
        {
            return name;
        }

        public string GetId()
        {
            return id;
        }

        public abstract void AddNode(Node node);

        public abstract void RemoveNode(Node node);
        public abstract void RemoveNode(string id);
        public abstract void PrintChildren();
    }
}
