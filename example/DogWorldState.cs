public class DogWorldState : WorldState
{
    public Boolean? HasFoodInBowl { get; set; }

    public Boolean? IsHungry { get; set; }

    public override WorldState AddOtherTo(WorldState other)
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

    public override int EstimatedDistance(WorldState other)
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

    public override bool IsEqualTo(WorldState other)
    {
        // TODO: really need some better solution than this casting
        return this.IsHungry == ((DogWorldState)other).IsHungry || this.HasFoodInBowl == ((DogWorldState)other).HasFoodInBowl;
    }

    public override bool IsSupersetOfOther(WorldState other)
    {
        Boolean isSupersetOfOther = true;

        if (((DogWorldState)other).IsHungry != null && ((DogWorldState)other).IsHungry != IsHungry) {
            isSupersetOfOther = false;
        }

        if (((DogWorldState)other).HasFoodInBowl != null && ((DogWorldState)other).HasFoodInBowl != HasFoodInBowl) {
            isSupersetOfOther = false;
        }

        return isSupersetOfOther;
    }
}