public class Action {
    public Action(
        int cost, 
        string name, 
        WorldState preconditions, 
        WorldState effects
    ) {
        Cost = cost;
        Name = name;
        Preconditions = preconditions;
        Effects = effects;
    }

    public int Cost { get; }

    public string Name { get; }

    public WorldState Preconditions { get; }

    public WorldState Effects { get; }
}