public class GoapTreeNode {

    public GoapTreeNode(GoapTreeEdge[] edges, WorldState worldState) {
        Edges = edges;
        WorldState = worldState;
    }

    public GoapTreeEdge[] Edges { get; }

    public WorldState WorldState { get; }
}