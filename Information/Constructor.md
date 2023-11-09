# Constructor

A constructor is a class method, with the same name as the class, that let's your populate fields with values on creation of a new instance.

Bringing back our basic car class.

```csharp
public class Car {

       public string Make;
       public string Model;
       public double Mileage;
       public int Year;
}
```

Basic Car Class	

|Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|          |      |       |         |      |

### Why use constructors?
Constructors let you control what information MUST be added when an object is created.


 	 	 	 
`Car car1 = new Car();`  


|Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|   car1       |      |       |         |      |

Here we create a car instance, but it has no values. What if we need to guarentee we have values for at least make and model? We can create a constructor to take make and model.

#### Basic Car Class with Make and Model Constructor
```csharp
public class Car {
       // Constructor with parameters
       public Car(string make, string model) {

             this.Make = make;
             this.Model = model;
       }
}
```

This gets rid of the default constructor, so you can't create an empty object initially. Then it forces the user to enter these two pieces of the required information. If you didn't pass in a make-and-model argument, you would receive an error.

 

#### Car with arguments	

`Car car1 = new Car("Honda", "Civic");`
 
 |Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|   car1       |   Honda   |    Civic   |         |      |

Here we pass in two strings, "Honda" and "Civic". This assigns those values to our instances fields ( code below ). Mileage and Year are both still empty, but we can make constructors for those too if we desired. 

The goal of a constructor is to allow or restrict the user from creating an instance of an object with populated values.

 

### Creating a Constructor
 

A constructor is written like a method inside of your class but has some key differences.

Constructor Syntax
Same name as the class
No return type
Starts with upper case

```csharp
public class Car {

     // Constructor

     public Car() {

          // Code in Constructor

     }

}
 ```

When you create a constructor it has no return type and is given the same name as the class, starting with an uppercase. Besides that, they work very similarly to methods.

The example above is the equivalent of a default constructor, which you can see more about below. It can be used to create an instance of a class but doesn't populate any fields.

 

### Creating a Constructor with Parameters
One of the most important uses of constructors is allowing and even forcing, users to populate fields and values when creating a new instance of an object.

Below we make a new car with our constructor, but then to add values to its fields we manually add them one at a time to our car instance. This is in inefficient and time-consuming. 

#### Making a new Car object ( instance )	

```csharp
Car car1 = new Car();
car1.Make = "Buick";
car1.Model = "Encore";
car1.Mileage = 60000;
car1.Year = 2015;
 ```

  |Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|   car1       |   Buick   |    Encore   |    60000     |   2015   |


Instead, we can make a constructor that takes parameters, just like a method. 

 

### Basic Car Class with Constructor

```csharp
public class Car {

       public string Make;

       public string Model;

       public double Mileage;

       public int Year;

       // Constructor with parameters
       public Car(string make, string model, double mileage, int year) {

             this.Make = make;
             this.Model = model;
             this.Mileage = mileage;
             this.Year = year;
       }

}
 ```

#### Creating a new instanced object with our constructor

`Car car2 = new Car("Toyota", "Rav4", 123455, 2016);`
 
Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|   car2       |   Toyota   |    Rav4   | 123455 |   2016   |

A few things to notice here. 

1. I create parameters for each field. This is not required. You can have a parameter for 1, 3, all of them. It's your choice. It depends on what fields you want / need populated when an instance is first created. You can even create multiple constructors, which is called overloading, which we discuss below.
2. I use the same names as our fields. This isn't necessary but is very common. 
3. I use this keyword. this refers to the instanced field of the object. It's like referring to itself. It guarantees the "make" string being passed in to the "Make" field associated with the object. 


Important: This get's rid of the default constructor. If you try to create a new Car() after creating a constructor with any parameters, you'll get an error. You will need to manually create your own constructor with no parameters.
 

### Basic Car Class with 2 Constructors

```csharp
public class Car {

       // Creating a constructor with parameters removes the default
       // constructor. You can make your own though
       public Car(string make, string model, double mileage, int year) {

             this.Make = make;
             this.Model = model;
             this.Mileage = mileage;
             this.Year = year;
       }

       public Car() {}

       // Now this class has 2 constructors. 
       // One with and one without parameters
       

}
 ```

### Default Constructor
When a class is first created, it has a default constructor. This is a constructor that has the same name as a class, but takes no parameters. It doesn't even appear in the class.

Basic Car Class	

| Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|   car1       |      |       |  |      |
 	 	 	 
```csharp
public class Car {

       public string Make;

       public string Model;

       public double Mileage;

       public int Year;

}


public static void Main(string[] args) {

        // Default Constructor
       Car car1 = new Car();

}
```

Here we call our default constructor with the new keyword, new Car(). This creates an instance of the car, but none of the fields have any values.

 

Overloading Constructors
You can have as many constructors as you need for your class. You just need to make sure that the constructor as a different amount, or type of parameters, than another.

 

### Basic Car Class with 3 Constructors

```csharp
public class Car {

       // Constructor that takes no arguments
       public Car() {}

       // Constructor that takes only 2 arguments
       public Car(string make, string model) {

           this.Make = make;
           this.Model = model;

        }

       // Constructor that takes arguments for all fields
       public Car(string make, string model, double mileage, int year) {

             this.Make = make;
             this.Model = model;
             this.Mileage = mileage;
             this.Year = year;
       }      

}
```

Now you can create cars using any of these 3 constructors.

Creating a new instanced object with our constructor

```csharp
Car car1 = new Car();
Car car2 = new Car("Hyundai", "Sonata");
Car car3 = new Car("Toyota", "Rav4", 123455, 2016);
```


Cars
Variable	Make	Model	Mileage	Year
car1				
car2	Hyundai	Sonata		
car3	Toyota	Rav4	123455	2016

| Unique ID | Make | Model | Mileage | Year |
| ---      | ---  | ---   | ---     | ---  |
|   car1       |      |       |  |      |
|   car2       |   Hyundai   |    Sonata   |  |      |
|   car3       |   Toyota   |    Rav4   | 123455 |   2016   |

## Important

You cannot create two constructors that have the same combination of parameter types.

#### Basic Car Class with 2 Constructors

```csharp
public class Car {

       // Constructor that takes no arguments
       public Car() {}

       // Constructor that takes only 2 arguments
       public Car(string make, string model) {

           this.Make = make;
           this.Model = model;

        }

      // Error!
       public Car(string model, string make) {

          this.Make = make;
          this.Model = model;

       }

}
 ```

Even thou we swapped our variable names, make and model to model and make, the computer see's one thing.

```Car(string, string)```

So the compiler doesn't know which constructor you are trying to access. That's why you can't have two constructors with the same arrangement and types of variables. We discuss this more in method overloading.