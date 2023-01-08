public class GoapPlanner<T> {
    public GoapPlanner(WorldState<T> goal, WorldState<T> start) {
        Goal = goal;
        Start = start;
    }

    public WorldState<T> Goal { get; }

    public WorldState<T> Start { get; }

    public Action[] plan() {
        return new Action[0];
    }
}