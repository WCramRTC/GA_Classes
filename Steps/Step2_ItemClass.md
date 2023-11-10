# Step 2 - Item Class

In this step we are going to create our class, `Item`. This is going to represent an item in a grocery store. 

---
## Creating The Item Class

1. In the Solution Explorer, right click the `.csproj` file. This is the second file in the solution explorer, it has a green icon and is given the same name as our project.

![Project File](Images/Project_File.png)

2. In the menu, hover over ***Add*** and then ***Class***. A prompt to name your new class shows up.

> Always name your class with an upper case letter, and singular  
>  * Good: Item  
>  * Bad: item  
>  * Bad: Items

3. Name your project `Item`.

You should have a new file called `Item.cs` in your solution explorer. Open it.

`Item Class`
```csharp
internal class Item {

}

```

4. In your item class, change the access modifier at the top from ***`internal`*** to ***`public`***

`Item Class`  
***`Code To Add`***
```csharp
public class Item {

}
```


---

## Adding Fields
[Fields](../Information/Fields.md)

Fields represent the data associated with our object. They are the same as the variable we have been using, but all related to our one object.

> For our Item, were treating it as if it's a grocery story item. And potentially for our online store. Becuase of this we are creating 4 seperate fields.
> * Name - The name of our product
> * Description - The short description of our product
> * Price - The Current Price of our Product
> * Discount - The discount in percentage for our product

1. Add the following fields to the inside of your `Item` class.

While you could have fields be public, we tend to keep them private for security reasons. We will create properties further down to allow access.

Field names also tend to start with an underscore, _. This is a naming convention. It won't break the code, but it's commonly used, and easily allows us to see when a variable is a field.

Ex. `string _name;`

`Fields`  
***`Code To Add`***
```csharp

    // Fields
    string _name;
    string _description;
    double _price;
    double _discount;

```

## Adding a Constructor
[Constructor](../Information/Constructor.md)

A Constructor lets us define the Data required for someone to create a new instance of our object ( Check out the Constructor page for more detail ).

We are going to create 2 Constructors, one that takes arguments for all 4 fields, and one that takes 2 arguments, one for name and one for price.

> Default Constructor: By default a class comes with a default constructor, `Item()`. This takes no arguments. By creating your own constructor, like we are here, it automatically gets rid of the default constructor.   
    Ex. `new Item();` <--- Will give an error.  
    You can always create your own default constructor by defining public `Item()` in your class.


To create a constructor the format is  
> Access Modifier - Class Name - Parameters  

> For our class it will be `public Item(string name, string description, double price, double discount) { }`

1. To create a constructor inside of our Item class we add the following code.  

***`Code To Add`***
```csharp
    // Constructor
    public Item(string name, string description, double price, double discount)
    {
        // Field = argument
        _name = name;
        _description = description;
        _price = price;
        _discount = discount;

    } // Item
```

The field names ( indicated by the underscore, _ ) are being assigned the values passed in as arguments.

Field = Argument : `_name = name;`

> This constructor now prevents someone from creating a new instance with no data.  

### ***Example*** 
```csharp
Item apple = new Item(); // Throws Errors
Item apple = new Item("Apple", "Red Delicious", 1.50, .1); // No Errors
```

We are now going to ***Add Another Constructor***.

> Overload: Creating multiple methods (or constructors) with the same name but different types of parameters is called ***overloading.***

2. Create another constructor that takes a name and price paremeter, but sets the description to "", and discount to 0.

`Constructors`  
***`Code To Add`***
```csharp

    // Take a name, and a price
    public Item(string name, double price)
    {
        _name = name;
        _price = price;          
        _description = "";
        _discount = 0;
    }

```

But offering multiple constructors, we give different options to the user. We may not require a description and discount when adding a new `Item` so we create a constructor that can just take those two arguments.

***Result***  
You now have two options for Constructors when creating a `new Item()`.

### ***Example*** 
```csharp
    // Constructor ( string name, string desc, double price, double discount)
    Item apple = new Item("Apple", "Granny Smith", 2.00, .2);
        // Name = Apple
        // Desc = Granny Smith
        // Price = 2.00
        // Discount = .2

    // Constructor ( string name, double price)
    Item fudge = new Item("Fudge", 3.00);
        // Name = Fudge
        // Desc = ""
        // Price = 3.00
        // Discount = 0
```


---
## Properties
[Properties](../Information/Properties.md)

If fields are the information related to our `Item`, the properties allow access to that information.

We might now always want others to change or even see information assoicated with our class.

### ***Example***
```csharp
// Widly dangerous becuase anyone could change it
public string socialSecurityNumber;
```

So we create properties. Properties are associated with a field, and using the keywords `get` and `set` you can allow access to reading and writing to our fields.

The format for a property is  
> Access Modifier - Return type of field - Name - NO PARENTHESIS  
> `get` - if you want to allow the user to read the info  
> `set` - if you want to allow the user to change the info  

* Below we see we give the access modifer of `public`. This is most common, but can be changed if needed. 
* Then the return type. Since our `_name` field is a `string` we are returning a `string` type. 
* Next is the `Name`. Notice, it's the same as our field but has no underscore and is upper case.
    * Field: `_name`
    * Property: `Name`

`Properties`  
***`Code To Add`***
```csharp
    // access modifer - Return Type - Name ( Same as the Field )
    // DOES NOT TAKE PARAMETERS
    public string Name
    {

    } // Name
```

Now we are going to add our keywords `get` and `set` to our `Name` property.

### Get

The `get` keyword is placed inside our property, followed by curly braces. This also has no parenthese.

Inside of our get we type `return _name`. This is returning the value associated with our field `_name`.

***`Code To Add`***
```csharp
    public string Name {
        // This is a get, it lets the user READ the value
        get {
            return _name;
        }
    }
```

Without a get, this would prevent the user from reading the data.

### ***Example*** 
```csharp

    Item fudge = new Item("Fudge", 1.50);

    // With get
    Console.WriteLine(fudge.Name); // "Fudge"

    // Without get
    Console.WriteLine(fudge.Name); // Error

```

Now lets add a `set`

### Set

If a get allows the user to READ the data, the set allows the user to WRITE the data.

Without a set we would get an error trying to change a value.  
### ***Example*** 
```csharp
    Item fudge = new Item("Fudge", 1.50);
    fudge.Name = "Cookie"; // Error
```

That's why we will add a `set`.

***`Code To Add`***
```csharp
    public string Name {

        get {
            return _name;
        }
        // Add This
        set {
            _name = value;
        }
    }
```

Our `set` is like our `get`, the keyword and curly braces, {}. Inside we do our field name followed by the keyworld value.
> `set { _fieldName = value; }`

The `value` keyword represents whatever is being assigned to the variable.

### ***Example***
```csharp
    // Property = value
    fudge.Name = "Cookie";
```

By adding the `set` you allow the user to change the value. Now lets add properties for Description.

---
```Code To Add```
```csharp

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

```

Now we are going to want to add a property for our price and discount, but we are going to add in some validations.

```Code To Add```
```csharp
    public double Price
    {
        get { return _price; }
        set
        {
         // Prevent a negative number from being ASSIGNED to an item
            if(value >= 0)
            {
                _price = value;
            }        
        }
    } // Price
```

Notice, our property is almost the same as before, but inside of our set we did an `if statement` around our `_price = value;`. This if statement, using the `value` keyword checks to see if the value being assigned is greater than 0, or not a negative number. If it's a postive number, the value will change, otherwise nothing happens.

Let's do the same for discount, but since we want our discount number to be between 0 and 1, we will set another if for that range.

```Code To Add```
```csharp

    public double Discount
    {
        get { return _discount; }
        set
        {
            // 0 --------------------- 1
            if(value >= 0 && value <= 1)
            {
                _discount = value;
            }
        }
    }
```

***Result***  
All said and done, you should have 4 properties.  

1. `public string Name { get; set;}`  
2. `public string Description {get; set; }`  
3. `public double Price { get; set ;}` // Validate for negatives  
4. `public double Discount {get; set; }` // Validate between 0 and 1  

---
## Class Methods
[Methods](../Information/Methods.md)

A class method is a method, built like normal. But being build inside of a class, it has access to all the class fields. It will also work with the data associated with the specific instance.

Let's start by adding a method called `DiscountedAmount()`. It should return a double, because we will want to do math with the cauculated amount afterwards.


`Methods`   
***`Code To Write`***
```csharp
    // Class Method
    public double DiscountedAmount()
    {
        return Price * Discount;
    }
```

This code Mutiplies the current price by the discounted amount. The result is the total amount saved.
> Ex: Price = 100 and Discount = .1 ( 10 %).  
> Price * Discount ( 100 * .1 ) = 10

And we will add another method, `CalculateTotalPrice()` that returns the cost after the discount is deducated. 

```csharp
    public double CalculateTotalPrice()
    {
        return Price - DiscountedAmount();
    }
```

Notice, we use our method we just build, `DiscountedAmount()` inside of our method. This is code reusability. It reduces writing the same equation over again.


### ***Example***

```csharp
    apple // Price = 2.00 and Discount = .2
    apple.DiscountedAmount(); // Result is .40
    apple.CalculateTotalprice(); // Result is 1.60

    fudge // Price = 5.00 and Discount = .15
    fudge.DiscountedAmount(); // Result is .75
    fudge.CalculateTotalAmount(); // Result is 4.25

```


---
## `Override ToString()`
[Override To String](../Information/OverrideToString.md)


We'll get into more detail in Programming 3, but for reusability there are methods we are allowed to `override`. This means even through we didnt' write the original method, we can change how it behaves.

In our code enter the following code.


`override ToString()`
```csharp
    // OVERRIDE ToString()
    public override string ToString()
    {
        // Name: Granny Smith - Price: $1.50 - Discount: $0.15 - Total Price: $1.35
        return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {DiscountedAmount().ToString("c")} - Total Price: {CalculateTotalPrice().ToString("c")}";
    } // ToString()
```

***Result***  
With this final result, when you call `.ToString()` on your method, it will display your formatted string, not the generic one you usually see. This will make working with it a lot easier.

---

# Next step [Step 3 - Display a List of Items](Step3_DisplayingAListOfItem.md)

## Finished Code

```csharp
    public class Item
    {

        // Fields
        string _name;
        string _description;
        double _price;
        double _discount;

        // Constructor
        // Access Modifer - SAME EXACT NAME AS THE CLASS - Take Paremeters

        
        public Item(string name, string description, double price, double discount)
        {
            // Field = argument
            _name = name;
            _description = description;
            Price = price;
            Discount = discount;

        } // Item

        // new Item("Fudge", -2000);
        // Take a name, and a price
        public Item(string name, double price)
        {
            _name = name;
            Price = price;          
            _description = "";
            Discount = 0;
        }

        // Overloading A Constructor
        // Overload a method - You are creating a method that has the same NAME as another method, but different paremeters. That does the same thing but with different data. 

        // Properties
        // Get and Set
        // access modifer - Return Type - Name ( Same as the Field )
        // DOES NOT TAKE PARAMETERS
        public string Name
        {
            // key word get
            get // Give Permission to READ Data
            {
                return _name; // Return the field
            }
            set
            {
                _name = value;
            }

            // keyword set AND value


            // key word set
        } // Name

        // Apple.Name = "Red and Delicious"
        // .Name = value

        public string Description
        {
            get
            {
                return _description;
            }
            set => _description = value;
        }

        // Create the property for PRice, double
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                // Prevent a negative number from being ASSIGNED to an item
                if(value >= 0)
                {
                    _price = value;
                }        

            }



        } // Price

        public double Discount
        {
            // Lambda
            get => _discount;

            set
            {
                // -2000 
                // 0 --------------------- 1
                if(value >= 0 && value <= 1)
                {
                    _discount = value;
                }

            }
        }

        // Class Method
        public double DiscountedAmount()
        {
            return Price * Discount;
        }

        public double CalculateTotalPrice()
        {
            return Price - DiscountedAmount();
        }

        // OVERRIDE ToString()
        public override string ToString()
        {
            // Name: Granny Smith - Price: $1.50 - Discount: $0.15 - Total Price: $1.35
            return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {DiscountedAmount().ToString("c")} - Total Price: {CalculateTotalPrice().ToString("c")}";
        } // ToString()
}
```