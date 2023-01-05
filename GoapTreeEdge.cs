public class GoapTreeEdge {
    public GoapTreeEdge(Action action, GoapTreeNode child, GoapTreeNode parent) {
        Action = action;
        Child = child;
        Parent = parent;
    }

    public Action Action { get; }

    public GoapTreeNode Child { get; }

    public GoapTreeNode Parent { get; }
}