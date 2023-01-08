public class GoapTreeEdge<T> {
    public GoapTreeEdge(Action action, GoapTreeNode<T> child, GoapTreeNode<T> parent) {
        Action = action;
        Child = child;
        Parent = parent;
    }

    public Action Action { get; }

    public GoapTreeNode<T> Child { get; }

    public GoapTreeNode<T> Parent { get; }
}