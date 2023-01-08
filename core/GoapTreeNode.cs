public class GoapTreeNode<T> {

    public GoapTreeNode(GoapTreeEdge<T>[] edges, WorldState<T> worldState) {
        Edges = edges;
        WorldState = worldState;
    }

    public GoapTreeEdge<T>[] Edges { get; }

    public WorldState<T> WorldState { get; }
}