public class DogWorldState : WorldState
{
    public Boolean? HasFoodInBowl { get; set; }

    public Boolean? IsHungry { get; set; }

    public override WorldState AddOtherTo(WorldState other)
    {
        DogWorldState newState = new DogWorldState();
        newState.IsHungry = ((DogWorldState)other).IsHungry;
        newState.HasFoodInBowl = ((DogWorldState)other).HasFoodInBowl;

        if (((DogWorldState)other).IsHungry == null) {
            newState.IsHungry = IsHungry;
        } else if (((DogWorldState)other).HasFoodInBowl == null) {
            newState.HasFoodInBowl = HasFoodInBowl;
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