public class DogWorldState : WorldState<DogWorldState>
{
    public Boolean? HasFoodInBowl { get; set; }

    public Boolean? IsHungry { get; set; }

    public override DogWorldState addTo(DogWorldState other)
    {
        DogWorldState newState = new DogWorldState();
        newState.IsHungry = this.IsHungry;
        newState.HasFoodInBowl = this.HasFoodInBowl;

        if (IsHungry == null) {
            newState.IsHungry = other.IsHungry;
        } else if (HasFoodInBowl == null) {
            newState.HasFoodInBowl = other.HasFoodInBowl;
        }

        return newState;
    }

    public override bool isEqualTo(DogWorldState other)
    {

        return this.IsHungry == other.IsHungry || this.HasFoodInBowl == other.HasFoodInBowl;
    }
}