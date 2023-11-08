# GA_Classes

1. Class
2. Collection of Classes
3. Class With Methods
4. Classes IN Classes

---

## Assignment

***Required ChatGPT Acction***  
You are going to use chat gpt to help generate lists of data for you to work with.

1. Create a WPF appliation with the name of GA_***YourName***_Classes
2. Replace `<Grid>` with our new xaml code. And double click on the 2 buttons and lbInventor to create events. 




Choose a topic to create a  data class on
1. Create a class called `Item`
    * Give it 4 fields
        1. `string _name` <--- This is for the name of the item
        2. `string _desciption` <---- Discription of the item
        3. `double _price` <--------
        4. `double _discount` <------
    * Create 2 Constructors.
        1. One that takes all fields as arguments
        2. One that takes only a name and a price.  
            **Set description to an empty string, and discount to 0**
    * Create properties for all 4 fields
        1. Get and Set for Name
        2. Get and Set for Description
        3. Get and Set for Price
            * Validate the price to make sure its above 0
        4. Get and Set for Discount
            * Validate the discount to make sure its above 0 and below 1. ( You wouldn't want someone to have a discount of 150%)
    * Create 2 Methods
        1. `public double DiscountedAmount()`
            * This should return the the the dollar amount of the discount
            * Ex : If the amount is 10, and the discount is .1 ( 10% ) then the method should return 1 ( 1 dollar )

        ```
           public double DiscountedAmount()
        {
            return Price * Discount;
        } // DiscountedAmount()

        public double CaculateTotalPrice()
        {
            return Price - DiscountedAmount();
        } // CalculateTotalPrice()

        public override string ToString()
        {
            return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {_discount.ToString("c")} - Total Price: {_price.ToString("c")}";
        } // ToString()
        ```

Start Xaml Code
```html
    <Canvas>
        <ListBox x:Name="lbInventory" Height="228" Width="253" d:ItemsSource="{d:SampleData ItemCount=5}" Canvas.Left="25" Canvas.Top="39" HorizontalAlignment="Left" VerticalAlignment="Center" />
        <RichTextBox Height="132" Width="252" Canvas.Left="25" Canvas.Top="282" HorizontalAlignment="Left" VerticalAlignment="Center">
            <FlowDocument>
                <Paragraph>
                    <Run x:Name="rtbItemDescription"/>
                </Paragraph>
            </FlowDocument>
        </RichTextBox>
        <Label Content="Inventory" Canvas.Left="25" Canvas.Top="8"/>
        <Button x:Name="btnAddToCart" Content="Add To Cart" Canvas.Left="302" Canvas.Top="217" Height="34" Width="91" HorizontalAlignment="Left" VerticalAlignment="Center" />
        <ListBox x:Name="lbShopping" Height="321" Width="293" d:ItemsSource="{d:SampleData ItemCount=5}" Canvas.Left="416" Canvas.Top="39" HorizontalAlignment="Center" VerticalAlignment="Top"/>
        <RichTextBox Height="373" Width="423" Canvas.Left="726" Canvas.Top="39" HorizontalAlignment="Left" VerticalAlignment="Center">
            <FlowDocument>
                <Paragraph>
                    <Run x:Name="rtbReciept" />
                </Paragraph>
            </FlowDocument>
        </RichTextBox>
        <Label Content="Shopping Cart" Canvas.Left="416" Canvas.Top="8" HorizontalAlignment="Left" VerticalAlignment="Center"/>
        <Label Content="Reciept" Canvas.Left="726" Canvas.Top="8" HorizontalAlignment="Left" VerticalAlignment="Center"/>
        <Button x:Name="btnTotalTransaction" Content="Total Transaction" Canvas.Left="416" Canvas.Top="383" HorizontalAlignment="Center" VerticalAlignment="Top" Width="293" Height="31"  />

    </Canvas>

```

1. Create a new C# class called `Item`.

```csharp

	public class Item {

		// Fields
		string _name;
		string _description;
		double _price;
		double _discount;

		// Constructor
		public Item(string name, string description, double price, double discount) {

			_name = name;
			_description = description;
			_price = price;
			_discount = price;
		}


		// Properties
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public double Discount { get; set; }

	}

```

`Preload method`
```csharp
        public void PreloadInventory()
        {
            inventory = new List<Item>
        {
            new Item("Yogurt", "Premium cut", 17.56, 0.2),
            new Item("Salt", "Soothing blend", 13.15, 0.64),
            new Item("Strawberries", "Crisp and fresh", 6.95, 0.18),
            new Item("Tomatoes", "Local farm product", 16.43, 0.57),
            new Item("Fish", "Starchy and filling", 1.68, 0.01),
            new Item("Garlic", "Freshwater", 11.83, 0.08),
            new Item("Salt", "Balsamic", 18.74, 0.24),
            new Item("Bread", "Lean and healthy", 7.91, 0.37),
            new Item("Lettuce", "Ripe and juicy", 16.81, 0.82),
            new Item("Beef", "Vitamin-rich", 11.44, 0.28),
            new Item("Quinoa", "Free-range", 3.17, 0.53),
            new Item("Tofu", "Spicy and colorful", 13.63, 0.44),
            new Item("Herbs", "Steel-cut", 3.23, 0.78),
            new Item("Bread", "Vitamin-rich", 16.96, 0.7),
            new Item("Soda", "High-protein", 1.71, 0.56),
            new Item("Peppers", "Balsamic", 11.93, 0.05),
            new Item("Chicken", "Lean and healthy", 12.11, 0.54),
            new Item("Quinoa", "Low-calorie", 9.26, 0.16),
            new Item("Beef", "Organic and fresh", 4.27, 0.29),
            new Item("Cheese", "Seedless variety", 7.94, 0.35),
            new Item("Soda", "Seedless variety", 2.11, 0.22),
            new Item("Olive Oil", "Fruit spread", 8.35, 0.36),
            new Item("Oats", "Crunchy snack", 3.56, 0.08),
            new Item("Ginger", "Zesty", 4.71, 0.71),
            new Item("Bread", "Crisp and fresh", 10.76, 0.5),
            new Item("Nuts", "Fruit spread", 8.76, 0.97),
            new Item("Peppers", "Grass-fed beef", 15.47, 0.78),
            new Item("Tofu", "Sugar-free", 10.21, 0.72),
            new Item("Nuts", "Local farm product", 16.03, 0.42),
            new Item("Vinegar", "Maple-flavored", 11.46, 0.35),
            new Item("Potatoes", "Freshly ground", 13.6, 0.77),
            new Item("Oats", "Grass-fed beef", 10.05, 0.71),
            new Item("Coffee", "Sweet treat", 6.92, 0.08),
            new Item("Chocolate", "Assorted herbs", 3.88, 0.9),
            new Item("Candy", "Sugar-free", 1.04, 0.8),
            new Item("Soda", "Juicy and flavorful", 6.42, 0.93),
            new Item("Pasta", "Premium cut", 10.34, 0.48),
            new Item("Jam", "Crunchy snack", 7.38, 0.51),
            new Item("Beef", "100% natural", 5.52, 0.68),
            new Item("Chocolate", "Fresh and tasty", 13.71, 0.32),
            new Item("Butter", "Vitamin-rich", 8.63, 0.3),
            new Item("Ketchup", "Full of flavor", 17.83, 0.97),
            new Item("Banana", "Crunchy snack", 8.8, 0.49),
            new Item("Herbs", "Extra virgin", 17.56, 0.14),
            new Item("Pepper", "Full of flavor", 13.66, 1.0),
            new Item("Water", "Steel-cut", 2.0, 1.0),
            new Item("Pepper", "Sweet and crunchy", 13.68, 0.58),
            new Item("Cheese", "Seedless variety", 4.03, 0.87),
            new Item("Tea", "Full of flavor", 9.9, 0.72),
            new Item("Grapes", "Sweet treat", 19.73, 0.05)
        };
        } // PreloadInventory()
```


---
# Final Code

`Item.cs`

```csharp
    public class Item
    {

        // Fields
        string _name;
        string _description;
        double _price;
        double _discount;

        // Constructor
        public Item(string name, string description, double price, double discount)
        {
            _name = name;
            _description = description;
            _price = price;
            _discount = discount;
        } // Item

        public Item(string name, double price)
        {
            _name = name;
            _price = price;
            _discount = 0;
            _description = "";
        } // Item


        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        } // Name

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        } // Decription

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                // Validating that Value is not a negative 
                if(value >= 0)
                {
                    _price = value;
                }
            }
        } // Price

        public double Discount
        {
            get { return _discount; }
            set
            {
                // Validating that the value is not negative or over 100 percent
                if(value >= 0 && value <= 1)
                {
                    _discount = value;
                }
            }
        } // Discount



        public double DiscountedAmount()
        {
            return Price * Discount;
        } // DiscountedAmount()

        public double CaculateTotalPrice()
        {
            return Price - DiscountedAmount();
        } // CalculateTotalPrice()

        public override string ToString()
        {
            return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {_discount.ToString("c")} - Total Price: {_price.ToString("c")}";
        } // ToString()


    } // class
```

`ShoppingCart.cs`
```csharp
    public class ShoppingCart
    {
        string _storeName;
        List<Item> _itemsInCart;
        double _tax;

        public ShoppingCart(string storeName)
        {
            _storeName = storeName;
            _itemsInCart = new List<Item>();
            _tax = .1;
        } // ShoppingCart()



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
                sum += item.Price;
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


        public string Reciept()
        {
            DateTime dto = DateTime.Now;
            string fullReciept = "";

            fullReciept += $"Welcome to {_storeName}\n";
            fullReciept += $"Date: {dto.ToShortDateString()} {dto.ToLongTimeString()}";
            fullReciept += $"\n-----\n\n";
            fullReciept += $"Items\n";
            foreach (Item item in _itemsInCart)
            {
                fullReciept += $"{item.ToString()}\n";
            }

            fullReciept += $"\n-----\n\n";
            fullReciept += $"Number Of Items : {_itemsInCart.Count}\n";
            fullReciept += $"Total Before Tax : {TotalBeforeTax().ToString("c")}\n";
            fullReciept += $"Tax : {TaxOnTotal().ToString("c")}\n";
            fullReciept += $"Total Price : {TotalPrice().ToString("c")}\n";
            return fullReciept;
        } // Reciept

    } // class
```

`MainWindow.cs`
```csharp
 public partial class MainWindow : Window
    {
        // Declare a list of Items
        List<Item> inventory;

        // And a Shopping Cart Object
        ShoppingCart cart;

        public MainWindow()
        {
            InitializeComponent();
            PreloadInventory();

            // Add to lbInventory ItemsSource
            lbInventory.ItemsSource = inventory;

            cart = new ShoppingCart("Wills Mart");

            lbShopping.ItemsSource = cart.ItemsInCart;

        } // MainWindow

        private void lbInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbInventory.SelectedIndex;
            Item selectedItem = inventory[selectedIndex];

            // Clear RichTextBox
            rtbItemDescription.Text = "";
            

            rtbItemDescription.Text += $"Name: {selectedItem.Name}\n";
            rtbItemDescription.Text += $"Desciption: {selectedItem.Description}\n";
            rtbItemDescription.Text += $"Price: {selectedItem.Price.ToString("c")}\n";
            rtbItemDescription.Text += $"Discount: {selectedItem.DiscountedAmount().ToString("c")}\n";
            rtbItemDescription.Text += $"Total Price: {selectedItem.CaculateTotalPrice().ToString("c")}\n";


        } // lbInventory_SelectionChanged

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbInventory.SelectedIndex;
            Item selectedItem = inventory[selectedIndex];

            cart.AddItem(selectedItem);

            // Refresh Cart Display
            lbShopping.Items.Refresh();

        } // btnAddToCart_Click

        private void btnTotalTransaction_Click(object sender, RoutedEventArgs e)
        {
            rtbReciept.Text = cart.Reciept();
        } // btnTotalTransaction_Click

        // PreloadInventory

        public void PreloadInventory()
        {
            inventory = new List<Item>
        {
            new Item("Yogurt", "Premium cut", 17.56, 0.2),
            new Item("Salt", "Soothing blend", 13.15, 0.64),
            new Item("Strawberries", "Crisp and fresh", 6.95, 0.18),
            new Item("Tomatoes", "Local farm product", 16.43, 0.57),
            new Item("Fish", "Starchy and filling", 1.68, 0.01),
            new Item("Garlic", "Freshwater", 11.83, 0.08),
            new Item("Salt", "Balsamic", 18.74, 0.24),
            new Item("Bread", "Lean and healthy", 7.91, 0.37),
            new Item("Lettuce", "Ripe and juicy", 16.81, 0.82),
            new Item("Beef", "Vitamin-rich", 11.44, 0.28),
            new Item("Quinoa", "Free-range", 3.17, 0.53),
            new Item("Tofu", "Spicy and colorful", 13.63, 0.44),
            new Item("Herbs", "Steel-cut", 3.23, 0.78),
            new Item("Bread", "Vitamin-rich", 16.96, 0.7),
            new Item("Soda", "High-protein", 1.71, 0.56),
            new Item("Peppers", "Balsamic", 11.93, 0.05),
            new Item("Chicken", "Lean and healthy", 12.11, 0.54),
            new Item("Quinoa", "Low-calorie", 9.26, 0.16),
            new Item("Beef", "Organic and fresh", 4.27, 0.29),
            new Item("Cheese", "Seedless variety", 7.94, 0.35),
            new Item("Soda", "Seedless variety", 2.11, 0.22),
            new Item("Olive Oil", "Fruit spread", 8.35, 0.36),
            new Item("Oats", "Crunchy snack", 3.56, 0.08),
            new Item("Ginger", "Zesty", 4.71, 0.71),
            new Item("Bread", "Crisp and fresh", 10.76, 0.5),
            new Item("Nuts", "Fruit spread", 8.76, 0.97),
            new Item("Peppers", "Grass-fed beef", 15.47, 0.78),
            new Item("Tofu", "Sugar-free", 10.21, 0.72),
            new Item("Nuts", "Local farm product", 16.03, 0.42),
            new Item("Vinegar", "Maple-flavored", 11.46, 0.35),
            new Item("Potatoes", "Freshly ground", 13.6, 0.77),
            new Item("Oats", "Grass-fed beef", 10.05, 0.71),
            new Item("Coffee", "Sweet treat", 6.92, 0.08),
            new Item("Chocolate", "Assorted herbs", 3.88, 0.9),
            new Item("Candy", "Sugar-free", 1.04, 0.8),
            new Item("Soda", "Juicy and flavorful", 6.42, 0.93),
            new Item("Pasta", "Premium cut", 10.34, 0.48),
            new Item("Jam", "Crunchy snack", 7.38, 0.51),
            new Item("Beef", "100% natural", 5.52, 0.68),
            new Item("Chocolate", "Fresh and tasty", 13.71, 0.32),
            new Item("Butter", "Vitamin-rich", 8.63, 0.3),
            new Item("Ketchup", "Full of flavor", 17.83, 0.97),
            new Item("Banana", "Crunchy snack", 8.8, 0.49),
            new Item("Herbs", "Extra virgin", 17.56, 0.14),
            new Item("Pepper", "Full of flavor", 13.66, 1.0),
            new Item("Water", "Steel-cut", 2.0, 1.0),
            new Item("Pepper", "Sweet and crunchy", 13.68, 0.58),
            new Item("Cheese", "Seedless variety", 4.03, 0.87),
            new Item("Tea", "Full of flavor", 9.9, 0.72),
            new Item("Grapes", "Sweet treat", 19.73, 0.05)
        };
        } // PreloadInventory()


    } // class
```