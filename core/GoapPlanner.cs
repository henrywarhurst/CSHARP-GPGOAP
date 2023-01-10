public class GoapPlanner<T> {
    public GoapPlanner(List<Action<T>> allAvailableActions, WorldState<T> goal, WorldState<T> start) {
        AllAvailableActions = allAvailableActions;
        Goal = goal;
        Start = start;
    }

    public List<Action<T>> AllAvailableActions { get; }

    public WorldState<T> Goal { get; }

    public WorldState<T> Start { get; }

    public List<Action<T>> plan() {
        // build out plan tree
        GoapTreeNode<T> start = new GoapTreeNode<T>(new List<GoapTreeEdge<T>>(), Start);

        // find best path through tree
        return new List<Action<T>>();
    }
}