// See https://aka.ms/new-console-template for more information

DogWorldState goal = new DogWorldState();
goal.IsHungry = false;

DogWorldState start = new DogWorldState();
start.IsHungry = true;
start.HasFoodInBowl = false;

// beg to human action
DogWorldState begToHumanPreconditions = new DogWorldState();
begToHumanPreconditions.HasFoodInBowl = false;
begToHumanPreconditions.IsHungry = true;

DogWorldState begToHumanEffects = new DogWorldState();
begToHumanEffects.HasFoodInBowl = true;

Action begToHuman = new Action(
    1, 
    "begToHuman", 
    begToHumanPreconditions, 
    begToHumanEffects
);

// eat food action
DogWorldState eatFoodPreconditions = new DogWorldState();
eatFoodPreconditions.HasFoodInBowl = true;
eatFoodPreconditions.IsHungry = true;

DogWorldState eatFoodEffects = new DogWorldState();
eatFoodEffects.HasFoodInBowl = false;
eatFoodEffects.IsHungry = false;

Action eatFood = new Action(
    1, 
    "eatFood", 
    eatFoodPreconditions, 
    eatFoodEffects
);

// eat grass action
DogWorldState eatGrassPreconditions = new DogWorldState();
eatGrassPreconditions.IsHungry = true;

DogWorldState eatGrassEffects = new DogWorldState();
eatGrassEffects.IsHungry = false;

Action eatGrass = new Action(
    10, 
    "eatGrass", 
    eatGrassPreconditions, 
    eatGrassEffects
);

List<Action> allAvailableActions = new List<Action>();
allAvailableActions.Add(begToHuman);
allAvailableActions.Add(eatFood);
allAvailableActions.Add(eatGrass);

GoapPlanner planner = new GoapPlanner(allAvailableActions, goal, start);

Console.WriteLine("Plan:");
List<Action> actions = planner.Plan();
for (int i=0; i<planner.Plan().Count(); ++i) {
    Console.WriteLine(i + 1 + ". " + actions[i].Name);
}
