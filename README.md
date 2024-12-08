# C# NullReferenceException Example

This repository demonstrates a common C# error: the `NullReferenceException`.  The `Bug.cs` file shows code that will throw this exception if the `MyProperty` is not properly initialized. The `BugSolution.cs` provides a solution to handle this scenario.

**Problem:**

Uninitialized objects can lead to unexpected crashes.  In this case, `MyProperty` is an integer, but if the program attempts to access its value before it's been assigned, a `NullReferenceException` will be thrown.

**Solution:**

Properly initializing the object's properties or using null checks before accessing them is the best approach.  The solution file shows safe methods to avoid this exception.