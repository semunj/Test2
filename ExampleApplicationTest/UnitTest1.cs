using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleApplication;

namespace ExampleApplicationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void combineArrayStringWithDelimiterTest()
        {
            StringUtilities str1 = new StringUtilities();
            string[] arr = { "DP1", "is", "cool" };
            string delim = " ";
            string output = str1.CombineArrayStringWithDelimiter(arr, delim);
            Assert.AreEqual(output, "DP1 is cool");
        }

        [TestMethod]
        public void replaceSpacesInStringByHyphens()
        {
            StringUtilities str1 = new StringUtilities();
            string output = str1.ReplaceSpacesInStringByHyphens("DP1 is cool");
            Assert.AreEqual(output, "DP1-is-cool");
        }
    }
}
