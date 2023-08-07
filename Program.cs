using System;


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