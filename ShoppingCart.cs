using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Classes
{
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

} // namespace
