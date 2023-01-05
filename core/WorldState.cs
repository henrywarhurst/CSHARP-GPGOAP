public abstract class WorldState<T> {

    abstract public T addTo(T other);
    
    abstract public Boolean isEqualTo(T other);
}