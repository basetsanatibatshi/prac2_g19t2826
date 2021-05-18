using NUnit.Framework;

namespace Oware.Tests
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
            //arrange//
            House creatingH = new House(4, 5);///creating a house///
            //act//
            creatingH.ResetHouse();///function im trying to test 
            //assert//
            Assert.AreEqual(4, creatingH.GetCount(), "your get house is not reseted");//what must be true

        }
    }
}