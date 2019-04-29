using NUnit.Framework;
using scheduller.data.DAO.Implementation;
using scheduller.data.DAO.Interfaces;

namespace Tests
{
    public class Tests
    {        

        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public void Test1()
        {
            IComplexJobDAO complexJobDAO = new ComplexJobDAO();
            complexJobDAO.SaveComplexJob("Test");
            Assert.Pass();
        }
    }
}