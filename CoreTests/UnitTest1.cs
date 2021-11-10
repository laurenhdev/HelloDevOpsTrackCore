using NUnit.Framework;

namespace CoreTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DenneFeiler()
        {
            Assert.Pass("Helt ok");
        }

        [Test]
        public void DenneFeilerIkke()
        {
            Assert.Pass("Alt ok");
        }
    }
}
