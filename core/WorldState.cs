public abstract class WorldState {

    abstract public WorldState addTo(WorldState other);
    
    abstract public Boolean isEqualTo(WorldState other);

    abstract public int estimatedDistance(WorldState other);
}