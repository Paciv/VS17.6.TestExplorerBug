using NUnit.Framework;

namespace TestFramework
{
    public class AssertHelper
    {
        public static void IsItReallyTrue(bool condition) => Assert.That(condition, Is.True);
    }
}
