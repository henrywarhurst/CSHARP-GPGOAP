public class GoapTreeNode<T> {

    public GoapTreeNode(List<GoapTreeEdge<T>> edges, WorldState<T> worldState) {
        Edges = edges;
        WorldState = worldState;
    }

    public List<GoapTreeEdge<T>> Edges { get; }

    public WorldState<T> WorldState { get; }
}