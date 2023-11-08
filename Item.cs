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

        // Parameters
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
            // Name: Granny Smith - Price: $1.50 - Discount: $.
            return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {DiscountedAmount().ToString("c")} - Total Price: {CalculateTotalPrice().ToString("c")}";
        } // ToString()
        //public override string ToString()
        //{
        //    return $"Name: {_name}";
        //}




        #region Finished Code
        //// Fields
        //string _name;
        //string _description;
        //double _price;
        //double _discount;

        //// Constructor
        //public Item(string name, string description, double price, double discount)
        //{
        //    _name = name;
        //    _description = description;
        //    _price = price;
        //    _discount = discount;
        //} // Item

        //public Item(string name, double price)
        //{
        //    _name = name;
        //    _price = price;
        //    _discount = 0;
        //    _description = "";
        //} // Item


        //// Properties
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //} // Name

        //public string Description
        //{
        //    get
        //    {
        //        return _description;
        //    }
        //    set
        //    {
        //        _description = value;
        //    }
        //} // Decription

        //public double Price
        //{
        //    get
        //    {
        //        return _price;
        //    }
        //    set
        //    {
        //        // Validating that Value is not a negative 
        //        if(value >= 0)
        //        {
        //            _price = value;
        //        }
        //    }
        //} // Price

        //public double Discount
        //{
        //    get { return _discount; }
        //    set
        //    {
        //        // Validating that the value is not negative or over 100 percent
        //        if(value >= 0 && value <= 1)
        //        {
        //            _discount = value;
        //        }
        //    }
        //} // Discount



        //public double DiscountedAmount()
        //{
        //    return Price * Discount;
        //} // DiscountedAmount()

        //public double CaculateTotalPrice()
        //{
        //    return Price - DiscountedAmount();
        //} // CalculateTotalPrice()

        //public override string ToString()
        //{
        //    return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {_discount.ToString("c")} - Total Price: {_price.ToString("c")}";
        //} // ToString()
        #endregion

    } // class

} // namespace
