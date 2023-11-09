# Override ToString()


Override is a keyword you can use with some methods, more detail in programming 3, that lets you change what the method does when called. ToString() is one of those methods.

When you call .ToString() on a reference type object, it returns the .GetType() ( This displays what the type of the current object is ).

You can change that by "overriding" the .ToString() of an object inside of the class.


## How to override .ToString()

```csharp
public override string ToString() {

     return "string";

}
```

### When you call .ToString() on a reference object


```csharp
Account account = new Account();
display.Text = account.ToString();
```

> namepsaceName.Account




## When you override .ToString()


`Code`
```csharp
public class Account {

      public override string ToString() {

           return "This is my account;

      }
}
```

`Usage`
```csharp
Account account = new Account();
display.Text = account.ToString();
```

> This is my account

---

### External References

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method

https://www.c-sharpcorner.com/blogs/override-tostring-method-in-c-sharp

https://dotnettutorials.net/lesson/why-we-should-override-the-tostring-method/


