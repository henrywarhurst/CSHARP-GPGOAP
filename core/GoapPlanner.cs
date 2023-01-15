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
        GoapTreeNode start = new GoapTreeNode(Start, 0, Start.EstimatedDistance(Goal));

        List<GoapTreeNode> unexplored = new List<GoapTreeNode>();
        unexplored.Add(start);

        while (unexplored.Count > 0) {
            // Find best option from unexplored list
            int minCostIndex = 0;
            GoapTreeNode current = unexplored[minCostIndex];
            int minCost = current.CostFromStart + current.EstimatedCostToGoal;

            for (int i=0; i<unexplored.Count; i++) {
                GoapTreeNode node = unexplored[i];
                int cost = node.CostFromStart + node.EstimatedCostToGoal;
                if (cost < minCost) {
                    minCost = cost;
                    current = node;
                    minCostIndex = i;
                }
            }
            unexplored.RemoveAt(minCostIndex);

            // Check if we are at the goal
            if (current.WorldState.IsEqualTo(Goal)) {
                return current.ActionsDeployedThusFar;
            }

            // Add new candidates for exploration
            foreach (Action action in AllAvailableActions) {
                if (!current.WorldState.IsSupersetOfOther(action.Preconditions)) {
                    continue;
                }

                WorldState newWorld = current.WorldState.AddOtherTo(action.Effects);
                GoapTreeNode newNode = new GoapTreeNode(
                    newWorld, 
                    current.CostFromStart + action.Cost, 
                    newWorld.EstimatedDistance(Goal)
                );
                // TODO: tidy this up
                newNode.ActionsDeployedThusFar = new List<Action>(current.ActionsDeployedThusFar);
                newNode.ActionsDeployedThusFar.Add(action);

                unexplored.Add(newNode);
            }
        }

        // shouldn't actually hit this
        return new List<Action>();
    }
}