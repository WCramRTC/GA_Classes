using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Classes
{
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

} // namespace
