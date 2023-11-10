# Class Methods

When a method is a part of a class, it has access to all the fields associated with that class, even if they are private. Like properties, this gives the user the ability to perform actions with the code, but still let's us restrict what they can do.

We'll take a look with our BankAccount class example.

#### Bank Account Class Example

```csharp
public class BankAccount {

     // Fields

     string _name;
     double _balance;

     // Constructor

     public BankAccount(string name, double balance) {

          _name = name;
          _balance = balance;
     }

     // Properties

     public string Name() { get => _name; set => _name = value; }
     public string Balance() { get => _balance; set => _balance = value }
}

```

## Creating a class method

Creating a class method is exactly the same as creating any other method, except

1. It doesn't need the word static and

2. It has direct access to all of the objects fields. Even if they are private.

### Adding a Class Method

```csharp
public class BankAccount {

     // Fields

     string _name;

     double _balance;

     // Constructor...
     // Properties ...

     // Method
     public void Deposit(double amount) {

          _balance += amount;
     }

}
```



Here we created a method to deposit money in our bank account

#### A class Method

```csharp
 public void Deposit(double amount) {

     _balance += amount; // Adds the amount
 }
 ```


We see our code adds the users amount directly to our field, _balance. This way we give the user the ability to add an amount, but not do something like reassign a value.

To use our method, we call it from an instance of a BankAccount object. Below I create a new BankAccount with a username of will and balance of 500.

Then I access will, followed by a period, our dot operator, then our method, Deposit(amount). I pass in an amount of 500.

The result is 500 being Deposited, added, to my account!

#### Using our deposit method

```csharp
BankAccount will = new BankAccount()
{
     Name = "Will",
     Balance = 500
}
```
	 
#### Bank Accounts
| Name |	Balance |
| --- | --- |
| Will |	5000 |


```csharp
   will.Deposit(500);
```
   

#### Bank Accounts
| Name |	Balance |
| --- | --- |
| Will |	1000 |


**HEADS UP!**

This code works, but the user is able to enter some invalid code, such as a negative value.

#### Passing in a negative value

```csharp
   will.Deposit(-5000);
```	 


#### Bank Accounts
| Name |	Balance |
| --- | --- |
| Will |	4500 |



This causes all kinds of trouble. So we want to prevent the user from doing this. So we are going to make sure we validate argument so it's not a negative.

#### Validating the argument

```csharp
 public void Deposit(double amount) {

// Checking if the amount is great than 0

    if(amount > 0 ) {

       _balance += amount; // Adds the amount
    }
    else {

        MessageBox.Show("Invalid amount");
    }
    
 }
 ```


We wrap our "_balance += amount" in a condition that asks if (amount > 0). Now only if it's a positive number will it deposit the amount. Otherwise we wrote an else to tell the user the information was invalid.

#### Passing in a negative value

```csharp
   will.Deposit(-5000);
```	

 X  
Invalid Amount
OK




### Bad Code
#### Bank Account Class Example

```csharp
BankAccount will = new BankAccount("Will", 500);
```
 
#### Bank Accounts
| Name |	Balance |
| --- | --- |
| Will |	500 |




Above I've created a single instance of a BankAccount with a Name of Will and a starting balance of 500 dollars. If I wanted to add 500 right now with properties would have to manually change or tell the computer to calculate the values.




### Bank Account Class Example

```csharp
BankAccount will = new BankAccount("Will", 500);

// Telling the computer to do the math - Bad
will.Balance += 500


// Doing math ourselves - WORSE
will.Balance = 1000
```

 
#### Bank Accounts
| Name |	Balance |
| --- | --- |
| Will |	1000 |




External References

https://www.w3schools.com/cs/cs_methods.php

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods


