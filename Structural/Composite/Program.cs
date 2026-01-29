using Structural.Composite;

var root = new CompositeNode("root");
var child1 = new CompositeNode("child1");
var child2 = new CompositeNode("child2");
root.AddNode(child1);
root.AddNode(child2);

root.PrintChildren();
child2.PrintParent();