# Fields


## What are fields
Fields are any variables that are a member of any class or struct.

Fields are created to hold long-term information. Usually, your standard variable is gone from memory when a method is done with it. But a field will be retained in memory as long as the instance it is associated with stays in memory, for instance, this is the heap.

## Declaring a field

A field is declared the same way as a regular variable. You can start with an access modifier, or commonly in classes, without an access modifier. Then the type and the name.




### Video Game Player Fields

```csharp
public class Player {

     public string Name;

     public int Health;
}
```


This gives all methods inside of your class access to these variables, while also not attaching them to any particular method scope.

The fields you create are directly related to the needs of the class and the application you are creating.




### Student Fields

```csharp
public class Student {

     public string Name;

     public int ID;

     public string Address;

     public bool IsEnrolled;


}
```



Above, we have a student class that has a Name, Id, Address, and IsEnrolled field. If our application needed it, we could add a List<int> for grades, double gpa, etc... Any type of fields needed for our application.




## Private Fields

Usually, your fields are kept private or have no access modifier. The names are also in lower case and start with an _ ( underscore ).

### Student Fields

```csharp
public class Student {

     string _name;

     int _id;

     string _address;

     bool _isEnrolled;


}
```



The reason is because we make not want our users to have unrestricted access to our fields. So for that we make our variables private, by default if you don't give a member an access modifier, it's private. This prevents users from accessing those fields directly.




### Student Fields

```csharp
public Student {
     public string Name; // Public
}


main() {
     Student sam = new Student();
     sam.Name = ""; // Removes name
}

public Student {
  string _name; // Private
}


main() {
 Student sam = new Student();
 sam._name = ""; // Error! 
}

```

## Naming Conventions

### Student Fields


```csharp
public class Student {

     string _name;

     int _id;

     string _address;

     bool _isEnrolled;


}
```



Field names, especially private ones, tend to start with an underscore and lower case letter. This is not required, but it makes it easy to identify which variables are fields.



 ---
### External References

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields


