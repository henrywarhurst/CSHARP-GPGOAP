public class DogWorldState : WorldState
{
    public Boolean? HasFoodInBowl { get; set; }

    public Boolean? IsHungry { get; set; }

    public override WorldState addTo(WorldState other)
    {
        DogWorldState newState = new DogWorldState();
        newState.IsHungry = this.IsHungry;
        newState.HasFoodInBowl = this.HasFoodInBowl;

        if (IsHungry == null) {
            newState.IsHungry = ((DogWorldState)other).IsHungry;
        } else if (HasFoodInBowl == null) {
            newState.HasFoodInBowl = ((DogWorldState)other).HasFoodInBowl;
        }

        return newState;
    }

    public override int estimatedDistance(WorldState other)
    {
        int cost = 0;
        int costStep = 1;

        if (HasFoodInBowl != ((DogWorldState)other).HasFoodInBowl) {
            cost += costStep;
        }
        if (IsHungry != ((DogWorldState)other).IsHungry) {
            cost += costStep;
        }

        return cost;
    }

    public override bool isEqualTo(WorldState other)
    {

        return this.IsHungry == ((DogWorldState)other).IsHungry || this.HasFoodInBowl == ((DogWorldState)other).HasFoodInBowl;
    }
}