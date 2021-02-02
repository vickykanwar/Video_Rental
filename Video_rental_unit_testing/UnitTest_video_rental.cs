using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental;
namespace Video_rental_unit_testing
{

    [TestClass]
    public class UnitTest1
    {
        classDB obj_Data = new classDB();
        [TestMethod]
        public void connectionString()
        {
            string Connection = obj_Data.ConnString;
            Assert.AreEqual(@"Data Source=LAPTOP-VF617FP0\SQLEXPRESS;Initial Catalog=Video_Rental;Integrated Security=True", Connection);
        }

        [TestMethod]
        public void Test_CustomerDelete()
        {
            string Message = obj_Data.CustomerDelete();
            Assert.AreEqual("Customer Details are filled completely", Message);
        }
    }
}
