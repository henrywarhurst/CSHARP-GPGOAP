public abstract class WorldState {

    abstract public WorldState AddOtherTo(WorldState other);
    
    abstract public Boolean IsEqualTo(WorldState other);

    abstract public Boolean IsSupersetOfOther(WorldState other);

    abstract public int EstimatedDistance(WorldState other);
}