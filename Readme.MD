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

#### Note some new changes in syntax for C# 6.0

```csharp
/// <summary>
/// A Person object with new C# 6.0 features.
/// </summary>
class Person
{
    /// <summary>
    /// This is read-only property
    /// </summary>
    public int PersonId {get;}

    /// <summary>
    /// This is auto-initialized.
    /// </summary>
    public int Age { get; set; } = 33;

    /// <summary>
    /// Note the usage of nameof operator
    /// </summary>
    /// <param name="o"></param>
    public void Method(object o)
    {
        // names of fields, properties, methods or types can be accessed.
        if (o == null) throw new ArgumentNullException(nameof(o));
    }

    /// <summary>
    /// Note the use of null propagation operator
    /// </summary>
    /// <returns></returns>
    public int? FindAge()
    {
        return this?.Age; 
    }
}
```