using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminalProject
{
   public class Register
   {

        public static decimal ProductTotal(decimal price, decimal quantity)
        {
            decimal totalAmount = price * quantity;

            return totalAmount;
        }



        public static decimal GrandTotal(decimal total, decimal tax)
        {
            decimal taxtotal = total * tax;
            decimal grandTotal = taxtotal + total;
            return grandTotal;
        }


        public static decimal ChangeBack(decimal totalCash, decimal totalPrice)
        {

            decimal change = totalCash - totalPrice;

            return change;
        }


        
   }


}
