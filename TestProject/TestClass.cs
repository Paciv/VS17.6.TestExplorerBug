using NUnit.Framework;
using TestFramework;

namespace TestLibrary
{
    [TestFixture]
    public class TestClass
    {
        [Theory]
        public void Test1(bool condition)
        {
            AssertHelper.IsItReallyTrue(condition);
        }
    }
}
