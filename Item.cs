using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Classes
{
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

} // namespace
