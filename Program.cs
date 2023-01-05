// See https://aka.ms/new-console-template for more information

Console.WriteLine(new Action(5, "hi").Name);

DogWorldState goal = new DogWorldState();
goal.IsHungry = false;

DogWorldState start = new DogWorldState();
start.IsHungry = true;
start.HasFoodInBowl = false;
