public class Action<T> {
    public Action(
        int cost, 
        string name, 
        WorldState<T> preconditions, 
        WorldState<T> effects
    ) {
        Cost = cost;
        Name = name;
        Preconditions = preconditions;
        Effects = effects;
    }

    public int Cost { get; }

    public string Name { get; }

    public WorldState<T> Preconditions { get; }

    public WorldState<T> Effects { get; }
}