public class GoapPlanner {
    public GoapPlanner(WorldState goal, WorldState start) {
        Goal = goal;
        Start = start;
    }

    public WorldState Goal { get; }

    public WorldState Start { get; }

    public Action[] plan() {
        return new Action[0];
    }
}