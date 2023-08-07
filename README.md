# GoF_Csharp_Facade_Pattern

Provides a simplified interface to a complex subsystem, making it easier to use.

```csharp
﻿using System;


// Client Class
class Client
{
    static void Main(string[] args)
    {
        Facade facade = new Facade();

        // Using the simplified facade methods
        facade.Operation1();
        facade.Operation2();
    }
}


// Complex Subsystem Classes
class SubSystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubSystemA: OperationA");
    }
}

class SubSystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubSystemB: OperationB");
    }
}

class SubSystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubSystemC: OperationC");
    }
}

// Facade Class
class Facade
{
    private SubSystemA subsystemA;
    private SubSystemB subsystemB;
    private SubSystemC subsystemC;

    public Facade()
    {
        subsystemA = new SubSystemA();
        subsystemB = new SubSystemB();
        subsystemC = new SubSystemC();
    }

    // Simplified methods that internally use the complex subsystems
    public void Operation1()
    {
        Console.WriteLine("Facade: Operation1");
        subsystemA.OperationA();
        subsystemB.OperationB();
    }

    public void Operation2()
    {
        Console.WriteLine("Facade: Operation2");
        subsystemB.OperationB();
        subsystemC.OperationC();
    }
}
```

## How to setup Github actions

![Csharp Github actions](https://github.com/luiscoco/GoF_Csharp-10.Facade_Pattern/assets/32194879/93be54c7-a71b-40c0-8553-be851f35d0af)

