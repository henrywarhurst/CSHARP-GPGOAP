## CSHARP-GPGOAP

A basic implementation of GOAP in C#.

### Running the example code

Run `Program.cs` - I use VSCode on MacOSX.

### Using this code

You must implement a class which inherits from `WorldState` in your code.

Inspect `examples/DogWorldState` for an idea of how this subclassing works.

Then, create your own `Action` objects, see `Program.cs` for some example actions for simulating a dog.

Finally, call `planner.Plan()` to produce a list of actions, generated by an A* search through the plan tree.

### References

This C implementation of GOAP was a helpful reference in developing this code: https://github.com/stolk/GPGOAP.

Jeff Orkin's GOAP page here contains a variety of helpful other references: https://alumni.media.mit.edu/~jorkin/goap.html.
