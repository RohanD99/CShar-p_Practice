using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CodingStandards                                       //namespace should be in Pascal case
{
    internal class NamingConventions                            //filename should be same as class name and in PascalCase
    {
    
        public class ShoppingCart                              //class name should be in Pascal case
        {
            int totalCount = 0;                                //variables name should be in camelCase
            private decimal _totalPrice;                       //private fields are prefixed with an underscore and use camelCase
            private bool _isActive;                            //bool variables should have 'is' prefix

            public void CalculateTotalPrice()                  //methods should be in PascalCase and use descriptive verbs to indicate their actions.
            {
                // logic
            }

            public void AddItemToCart(string itemName)         //method parameters are in camelCase and use descriptive names to indicate the purpose of the parameter.
            {
                // logic 
            }

            public void RemoveItemFromCart(string itemName)
            {
                // logic 
            }

            public decimal GetTotalPrice()
            {
                return _totalPrice;
            }
        }
    }

}

