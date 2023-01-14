public class GoapPlanner {
    public GoapPlanner(List<Action> allAvailableActions, WorldState goal, WorldState start) {
        AllAvailableActions = allAvailableActions;
        Goal = goal;
        Start = start;
    }

    public List<Action> AllAvailableActions { get; }

    public WorldState Goal { get; }

    public WorldState Start { get; }

    public List<Action> Plan() {
        // build out plan tree
        GoapTreeNode start = new GoapTreeNode(new List<GoapTreeEdge>(), Start, 0, Start.estimatedDistance(Goal));

        List<GoapTreeNode> unexplored = new List<GoapTreeNode>();
        unexplored.Add(start);

        while (unexplored.Count > 0) {
            // Find best option from unexplored list
            GoapTreeNode current;
            int minCost = int.MaxValue;
            for (int i=0; i<unexplored.Count; i++) {
                GoapTreeNode node = unexplored[i];
                int cost = node.CostFromStart + node.EstimatedCostToGoal;
                if (cost < minCost) {
                    minCost = cost;
                    current = node;
                }
            }

            // Check if we are at the goal

            // Add new candidates for exploration
        }

        // find best path through tree
        return new List<Action>();
    }
}