# Properties

## What are proprties and why do we use them?
Fields and Properties go hand and hand. Where fields are used to keep track of variables for long term in memory, they don't have any kind of restrictions to who or what get's access to them, outside of access modifiers. That's where Properties come in.




#### Video Game Player Fields

```csharp
public class Player {

     public string Name;

     public int Health;


}
```

The example above is bad practice. By making my variables public anybody can change the information to whatever they want. What if I didn't want the user to be able to change the name to an empty string? Or I needed to limit the players health to a range of 0 and 100. With public fields, we can't do that.




#### Player instance with field access

```csharp
Player p1 = new Player();
p1.Name = ""; // We don't want this
p1.Health = 20000; // We don't want this either
```

That's why we use properties. These restrict access to our fields.




#### Video Game Player Fields

```csharp
public class Player {

     string _name;

     int _health;
     
        public string Name {
     
          get => _name;
          set {
               if(value != "") _name = value;
          }
        }

     public int Health{

          get => _health;
          set {
                if(value >= 0 && value <= 100)
                _health = value;
          }
      }
}
```

The code we've written above does two things. 

The get returns the values from the field.

The set allows us to reassign a value. But by adding in a condition to both ( value != name, or value is between 0 and 100 ) we've restricted the user from breaking our code with illegal values.

--- 

## Creating a Property

#### Creating a property

```csharp
public class Player {

     string _name;

     public string Name {

        // Property Code Here
        }


}
```

Creating a property for a field is straight forward. You start with an access modifier, which is usually public since it's for the user to use.

Then a return type. This is directly related to the return type of the field. Notice above our return type is a string, because our field, _name, is a string.

Then the name. If you follow a proper naming convention, then your field should start with an _ and a lowercase letter. Our property name should be the Upper Case version of this.

Unlike a method or constructor, a property doesn't have parenthesis.

A property has 2 parts to it, a getter and setter, these control what the user can do with a property.

--- 

### Getters

A getter is used to give access to a field to a user. Without a getter, if a field is private there is no way to see the value assigned. A getter uses the key word get and returns the field. Get is placed inside of your property, and is followed by curly braces.

#### Getter

```csharp
public class Player {

     string _name;

     public Player(string name) {
          this._name= name;
     }

     public string Name {

        // Getter
        get {
                return _name; // return field
            }
        // Or short hand is
        // get => _name;
        }


}
```



### Accessing your getter

Using your property is like accessing a method that's a part of an object. Like rand.Next() or Console.Write().

### Using your getter in code

A getter just returns the information stored in the field.

This can be used by accessing the property like a field or method.

```csharp
public static void Main (string[] args) {

      Player p1= new Player("Will");
      Console.Write(p1.Name);// Getter at work

      }

}
```

> Result
> Will

> Restricting Access
>No getter



A property does not need a getter.

When we omit a getter, this prevents our user from getting the value of a field.

This is uncommon to have, but is still an option.

```csharp
public class Player {

     string _name;

     public Player(string name) {
           this.Name = name;
     }

     public string Name {

      // No getter
     }


}


public static void Main (string[] args) {

      Player p1= new Player("Will");
      Console.Write(p1.Name); // Error thrown

      }

}
```


## Setters

A setter controls what fields you can assign values to. This give's you the option to allow, restrict, or even control what kind of values are assigned to a field. 

#### Setter

```csharp
public class Player {

     string _name;

     public Player(string name) {
          this.Name = name;
     }

     public string Name {
          get => _name;

          // setter
          set {

               _name = value;
          }
        }


}

```

---

### Value Keyword

Value is a special keyword that represents what's being assigned to the field. It's like a parameter in a method, but used specifically for setters.

#### Value in a setter

```csharp
          ...
          set {

               _name = value;
          }


          Player p1 = new Player();
          
          // "Will" is the value
          p1.Name = "Will";
```




### Using value to control what is assigned

You can use conditions with setters, allowing you to control values that can be assigned to your fields.

We can use value in our condition to validate what gets assigned.

Below we use an if statement in our set, this if says "If the users value is above or equal to 0, assign it to age". This condition prevents a value like -5 from being assigned. 

#### Prevent Negative Values

 ```csharp         
          int _age;

          set {

               if(value >= 0) {
                   _age = value;
               }
          }
 ```

Because our condition only triggers if the value is over 0, when we try to assign a value below 0 nothing happens.

#### Prevent Negative Values

```csharp          
          Player p1 = new Player();
          p1.Age = 20;
          Console.Write(p1.Age); // Result 20

          p1.Age = -5;
          Console.Write(p1.Age); // Result 20
```

In the example above, we assigned 20, then -5 a couple lines after. Because -5 >= 0 is false is does not get assigned.

We can build our conditions to respond to an invalid value too.

#### Prevent Negative Values

```csharp          
          int _age;

          set {

               if(value >= 0) {
                   _age = value;
               }
               else {
                   _age = 0;
               }
          }
 ```

Now we've built our set to assign a value of 0 if the value is a negative.

#### Prevent Negative Values

```csharp  
          Player p1 = new Player();
          p1.Age = 20;
          Console.Write(p1.Age); // Result 20

          p1.Age = -5;
          Console.Write(p1.Age); // Result 0
```



This is an extremely simple and useful way of validating values.

---
### External References


https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties


