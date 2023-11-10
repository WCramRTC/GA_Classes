# Step 4 - Shopping Cart Class

In this step we learn how to next items In items. We create a new class `ShoppingCart`, and add a `List<Item>` to it to replicate how an online shopping cart will work. We use it to hold a separate list of items ( but which ***Reference*** the same items in memory. ). Then we create methods to calculate the total of our cart, and display all the information as a formatted receipt.

## 1. Create a new class, ShoppingCart

1. Just like our `Item` class, add a new class called `ShoppingCart`.
2. Add the following `Fields`
    1. `string _storeName;`
    2. `List<Item> _itemsInCart;`
    3. `double _tax;`

```csharp
        // Fields
    string _storeName;
    List<Item> _itemsInCart;
    double _tax;
```

3. Create a constructor that takes a single parameter, `storeName`.
    * Inside the constructor
    * Assign the argument to the field, `_storeName = storeName`
    * Initialize our new List<Item>, `_itemsInCart = new List<Item>();`
    * Set a value of .1 for the tax ( 10 % ), `_tax = .1;`

```csharp
    // Constructor
    public ShoppingCart(string storeName)
    {
        _storeName = storeName;
        _itemsInCart = new List<Item>();
        _tax = .1;
    } // ShoppingCart()
```

4. Create Properties for our fields.
    1. Store name should have a get and set `{ get; set; }`
    2. ItemsInCart should ONLY have a get `{ get; }`
    3. Tax should ONLY have a get `{ get; }`

```csharp
// Properties
    public string StoreName
    {
        get => _storeName; // This is shorthand for get
        set => _storeName = value; // This is shorthand for set
    } // StoreName

        
    public List<Item> ItemsInCart
    {
        get => return _itemsInCart;
    }

    public double Tax
    {
        get => _tax;
    } // Tax

```

5. Create methods for our Shopping cart.

    1. ***Add Item***  
        * This makes it easier to add items to our shopping cart
    
        ```csharp
            public void AddItem(Item item)
            {
                _itemsInCart.Add(item);
            } // 
        ```

    2. ***Total Before Tax***
        * This method will loop through the current cart full of items. It will sum up the total price of All the items, using the `Items.CalculateTotalPrice();` method, that already takes the discount into account. It then returns the total pre tax. 

        We have it return the value because we can then call this method to return a number we can perform math with else where.
    

        ```csharp
          public double TotalBeforeTax()
            {
                double sum = 0;
                foreach (Item item in _itemsInCart)
                {
                    sum += item.CalculateTotalPrice();
                }

                return sum;
            } // TotalBeforeTax()
        ```

    3. ***Tax On Total*** 
        * This method calculates the tax, in dollar form, from the items in our cart.
        * Ex: `250 * .1 = 25`, It would return a tax of 25 dollars.
        ```csharp
       public double TaxOnTotal()
        {
            return TotalBeforeTax() * _tax;
        } // TaxOnTotal()
        ```

    4. ***Total Price***
        * The total price combines the `TotalBeforeTax() + TaxOnTotal()` giving us the final price.

        ```csharp
         public double TotalPrice()
            {
                return TotalBeforeTax() + TaxOnTotal();
            } // TotalPrice()
        ```

    5. ***Receipt***
        * The final method will format a string that we will use to display the information as a receipt.

        ```csharp
            public string Receipt()
            {
                // This C# object will help us display the exact time the receipt is processed
                DateTime dto = DateTime.Now;
                // Creating an empty string to start formatting.
                string fullReceipt = "";

                // Concatenating our store name into our receipt
                fullReceipt += $"Welcome to {_storeName}\n";
                // Displaying the current day and time on the receipt
                fullReceipt += $"Date: {dto.ToShortDateString()} {dto.ToLongTimeString()}";
                fullReceipt += $"\n-----\n\n";
                fullReceipt += $"Items\n";

                // Using a foreach loop, we go through the items in our cart and concatenate the .ToString() to our receipt string. This will show every item in our cart.
                foreach (Item item in _itemsInCart)
                {
                    fullReceipt += $"{item.ToString()}\n";
                }

                // Displays all the final calculations and the final total
                fullReceipt += $"\n-----\n\n";
                fullReceipt += $"Number Of Items : {_itemsInCart.Count}\n";
                fullReceipt += $"Total Before Tax : {TotalBeforeTax().ToString("c")}\n";
                fullReceipt += $"Tax : {TaxOnTotal().ToString("c")}\n";
                fullReceipt += $"Total Price : {TotalPrice().ToString("c")}\n";
                return fullReceipt;
            } // Receipt
        ```

With our `ShoppingCart` class completely built, our final step is to add it to our application.

# The Final [Step5 Displaying Our Receipt](Step5_DisplayingOurReceipt.md)

---

## Full Code

```csharp

    public class ShoppingCart
    {
        // Fields
        string _storeName;
        List<Item> _itemsInCart;
        double _tax;

        // Constructor
        public ShoppingCart(string storeName)
        {
            _storeName = storeName;

            // Instantiated
            // Creating a new INSTANCE of an object
            // use the new keyword, it's creating a new INSTNACE of an object
            _itemsInCart = new List<Item>();
            _tax = .1;
        } // ShoppingCart()


        // Abstraction
        public void AddItem(Item item)
        {
            _itemsInCart.Add(item);
        } // 

        public string StoreName
        {
            get => _storeName;
            set => _storeName = value;
        } // StoreName

        
        public List<Item> ItemsInCart
        {
            get
            {
                return _itemsInCart;
            }
        }

        public double Tax
        {
            get => _tax;
        } // Tax

        public double TotalBeforeTax()
        {
            double sum = 0;
            foreach (Item item in _itemsInCart)
            {
                sum += item.CalculateTotalPrice();
            }

            return sum;
        } // TotalBeforeTax()

        public double TaxOnTotal()
        {
            return TotalBeforeTax() * _tax;
        } // TaxOnTotal()

        public double TotalPrice()
        {
            return TotalBeforeTax() + TaxOnTotal();
        } // TotalPrice()


        public string Receipt()
        {
            DateTime dto = DateTime.Now;
            string fullReceipt = "";

            fullReceipt += $"Welcome to {_storeName}\n";
            fullReceipt += $"Date: {dto.ToShortDateString()} {dto.ToLongTimeString()}";
            fullReceipt += $"\n-----\n\n";
            fullReceipt += $"Items\n";
            foreach (Item item in _itemsInCart)
            {
                fullReceipt += $"{item.ToString()}\n";
            }

            fullReceipt += $"\n-----\n\n";
            fullReceipt += $"Number Of Items : {_itemsInCart.Count}\n";
            fullReceipt += $"Total Before Tax : {TotalBeforeTax().ToString("c")}\n";
            fullReceipt += $"Tax : {TaxOnTotal().ToString("c")}\n";
            fullReceipt += $"Total Price : {TotalPrice().ToString("c")}\n";
            return fullReceipt;
        } // Receipt

    } // class
```