using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Unit_Test_ProductQty.Controllers;

namespace MVC_Unit_Testing_projects
{
    [TestClass]
    public class UnitTest_ProductQty
    {
        //We are checking product Quantity
        //Product quantity can not less then zero.
        [TestMethod]
        public void TestPositiveQty()
        {
            //arrang
            int qty = 10;
            HomeController objControler = new HomeController();

            //Act
            bool result = objControler.CheckQuantity(qty);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNegativeQty()
        {
            //arrang
            int qty = -10;
            HomeController objControler = new HomeController();
            //Act
            bool result = objControler.CheckQuantity(qty);

            //assert
            Assert.IsFalse(result);
        }

        
       
    }
}
