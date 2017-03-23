### What is New in C# 6.0 

This repository summarizes some developer productivity features of C# 6.0

```csharp
    /// <summary>
    /// A method that includes just one statement can be written in lambda syntax.
    /// </summary>
    class ExpressionBodiedMethod
    {
        public void PrintMe(string message) => Console.Write("message");
    }
```