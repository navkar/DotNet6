### What is New in C# 6.0 

This repository summarizes some developer productivity features of C# 6.0

#### Summary of changes in C# 6.0 syntax

```csharp
/// <summary>
/// A method that includes just one statement can be written in lambda syntax.
/// </summary>
class ExpressionBodiedMethod
{
    public void PrintMe(string message) => Console.Write("message");
}
```


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
#### Firing events in C# 6.0

##### In C# 5.0

```csharp
var handler = Event;
if (handler != null)
{
	handler(source, e);
}
```

##### In C# 6.0

```csharp
handler?.Invoke(source, e);
```

#### Exception filters in C# 6.0

```csharp
try
{
	// etc
}
catch(SomeException ex) when (ex.ErrorCode == 405)
{
	// write some handler here...
}
```

#### String interpolation

The string interpolation removes calls to `string.Format`. Instead of using 
numbered format placeholders in the string, the placeholders can include expressions.

##### In C# 5.0

```csharp
public override ToString()
{
	return string.Format("{0}, {1}", Title, Publisher);
}
```

##### In C# 6.0

```csharp
public override ToString() => $"{Title}{Publisher}";
```
