using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketsChecker.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestWithCompleteBrackets()
        {
            string input = "{}";
            bool expectedOutput = true;
            bool actualOutput = Core.BracketsChecker.Check(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestWithIncorrectBrackets()
        {
            string input = "}{";
            bool expectedOutput = false;
            bool actualOutput = Core.BracketsChecker.Check(input);
            Assert.AreEqual(expectedOutput, actualOutput);
            Console.WriteLine($"{input} - {expectedOutput}");
        }

        [TestMethod]
        public void TestWithIncompleteBrackets()
        {
            string input = "{{}";
            bool expectedOutput = false;
            bool actualOutput = Core.BracketsChecker.Check(input);
            Assert.AreEqual(expectedOutput, actualOutput);
            Console.WriteLine($"{input} - {expectedOutput}");
        }

        [TestMethod]
        public void TestWithString()
        {
            string input = "";
            bool expectedOutput = true;
            bool actualOutput = Core.BracketsChecker.Check(input);
            Assert.AreEqual(expectedOutput, actualOutput);
            Console.WriteLine($"{input} - {expectedOutput}");
        }

        [TestMethod]
        public void TestWithStringBrackets()
        {
            string input = "{abc...xyz}";
            bool expectedOutput = true;
            bool actualOutput = Core.BracketsChecker.Check(input);
            Assert.AreEqual(expectedOutput, actualOutput);
            Console.WriteLine($"{input} - {expectedOutput}");
        }
    }
}
