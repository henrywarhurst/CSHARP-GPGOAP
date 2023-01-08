// See https://aka.ms/new-console-template for more information

DogWorldState goal = new DogWorldState();
goal.IsHungry = false;

DogWorldState start = new DogWorldState();
start.IsHungry = true;
start.HasFoodInBowl = false;

GoapPlanner<DogWorldState> planner = new GoapPlanner<DogWorldState>(goal, start);

Console.WriteLine("Plan: " + planner.plan());
