public class GoapTreeNode {

    public GoapTreeNode(List<GoapTreeEdge> edges, WorldState worldState, int costFromStart, int estimatedCostToGoal) {
        Edges = edges;
        WorldState = worldState;
        CostFromStart = costFromStart;
        EstimatedCostToGoal = estimatedCostToGoal;
    }

    public List<GoapTreeEdge> Edges { get; }

    public WorldState WorldState { get; }

    public int CostFromStart { get; }

    public int EstimatedCostToGoal { get; }
}