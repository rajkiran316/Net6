using ConsoleApp;
using NUnit.Framework;

namespace TestProject
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
            Assert.Pass();
            DemoEnum.Test.Equals((DemoEnum)1);
        }
    }
}