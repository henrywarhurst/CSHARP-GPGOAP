public class GoapTreeNode {

    public GoapTreeNode(WorldState worldState, int costFromStart, int estimatedCostToGoal) {
        WorldState = worldState;
        CostFromStart = costFromStart;
        EstimatedCostToGoal = estimatedCostToGoal;
        ActionsDeployedThusFar = new List<Action>();
    }

    public WorldState WorldState { get; }

    public int CostFromStart { get; }

    public int EstimatedCostToGoal { get; }

    public List<Action> ActionsDeployedThusFar { get; set; }
}