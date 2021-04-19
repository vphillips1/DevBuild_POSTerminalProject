using System;
using Xunit;
using POSTerminalProject;
using System.Collections.Generic;

namespace POSTerminalTests
{
    public class UnitTest1
    {
      

        [Theory]
        [InlineData(4.50, 4, 18.00)]
        [InlineData(6.25, 2, 12.50)]
        [InlineData(3.50, 5, 17.50)]
        [InlineData(2.25, 4, 9.00)]
        [InlineData(7.15, 4, 28.60)]

        public void ProductTotalTest(decimal price, decimal quantity, decimal expected)
        {
            decimal result = Register.ProductTotal(price, quantity);
            Assert.Equal(expected, result);

        }


        [Theory]
        [InlineData(6, .06, 6.36)]
        [InlineData(5, .06, 5.30)]
        [InlineData(9.50, .06, 10.07)]
        [InlineData(22.25, .06, 23.58)]
        [InlineData(10, .06, 10.6)]

        public void GrandTotalTest(decimal total, decimal taxtotal, decimal expected)
        {
            decimal result = Math.Round(Register.GrandTotal(total, taxtotal),2);
            Assert.Equal(expected, result);

        }


        [Theory]
        [InlineData(25.25, 15.00, 10.25)]
        [InlineData(30.00, 10.15, 19.85)]
        [InlineData(10.25, 5.25, 5.00)]
        [InlineData(5.00, 4.75, .25)]
        [InlineData(10, 6, 4.00)]
        public void ChangeBackTest(decimal totalCash, decimal totalPrice , decimal expected)
        {

            decimal result = Register.ChangeBack(totalCash, totalPrice);
            Assert.Equal(expected, result);
        }

       
    }


   
}
