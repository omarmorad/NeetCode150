# NeetCode 150 Solutions

This project contains solutions to the NeetCode 150 problems, organized by category in separate folders.

## Folder Structure
```
NeetCode150/
├── Arrays/
│   ├── ContainsDuplicate.cs
│   ├── TwoSum.cs
├── LinkedList/
│   ├── ReverseLinkedList.cs
├── DP/
│   ├── ClimbingStairs.cs
└── Graphs/
    └── NumberOfIslands.cs
```

## How to Run Individual Solutions

Since this project contains multiple classes with `Main` methods, you need to specify which class to run when compiling.

### Method 1: Using dotnet run with --startup-object
To run a specific solution, use the following command format:

```bash
# For ContainsDuplicate
dotnet run --project ./NeetCode150.csproj --startup-object "NeetCode150.Arrays.ContainsDuplicate"

# For TwoSum
dotnet run --project ./NeetCode150.csproj --startup-object "NeetCode150.Arrays.TwoSum"

# For ReverseLinkedList
dotnet run --project ./NeetCode150.csproj --startup-object "NeetCode150.LinkedList.ReverseLinkedList"

# For ClimbingStairs
dotnet run --project ./NeetCode150.csproj --startup-object "NeetCode150.DP.ClimbingStairs"

# For NumberOfIslands
dotnet run --project ./NeetCode150.csproj --startup-object "NeetCode150.Graphs.NumberOfIslands"
```

### Method 2: Using MSBuild with /main option (Alternative)
You can also build with the StartupObject property and then run the executable:

```bash
# For ContainsDuplicate
dotnet build --property:StartupObject="NeetCode150.Arrays.ContainsDuplicate" && dotnet ./bin/Debug/net10.0/NeetCode150.exe
```

### Method 3: Temporarily comment out Main methods
Alternatively, you can temporarily comment out all `Main` methods except the one you want to run, then use:
```bash
dotnet run --project ./NeetCode150.csproj
```

## Template for New Problems

Each solution follows this template:

```csharp
using System;

namespace NeetCode150.[Category]
{
    // Problem: [Problem Name]
    // [Problem Description]
    
    public class [ClassName]
    {
        public [ReturnType] [MethodName]([Parameters])
        {
            // Solution implementation
            return default;
        }
        
        public static void Main(string[] args)
        {
            [ClassName] solution = new [ClassName]();
            
            // Test cases
            Console.WriteLine("Running test cases...");
            // Add test cases here
        }
    }
}
```

Happy coding!