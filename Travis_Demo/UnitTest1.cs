using NUnit.Framework;

namespace Travis_Demo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        public void Test1(int num)
        {
            Assert.That(num == 1);
        }
    }
}