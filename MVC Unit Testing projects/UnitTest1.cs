using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVC_Unit_Testing_projects
{
    [TestClass]
    public class UnitTest1
    {
        //We are checking product Quantity
        //Product quantity can not less then zero.
        [TestMethod]
        public void TestMethod1()
        {
            //arrang
            int qty = 10;

            //Act
            bool result = CheckQuantity(qty);

            //assert
            Assert.IsTrue(result);
        }

        public bool CheckQuantity(int qty)
        {
            return (qty >= 0 ? true:false);
        }
    }
}
