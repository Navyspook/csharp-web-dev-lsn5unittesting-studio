using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTestsNS
{
    [TestClass]
    public class BalancedBracketsTests
    {

        //BalancedBrackets str1;
        //BalancedBrackets str2;

        [TestInitialize]
        //public void CreateBalBrackObject()
        //{
        //    str1 = new BalancedBrackets("This is Balanced Brackets []");
        //    str2 = new BalancedBrackets("This is not ][");
        //}
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        //Want to pass
        [TestMethod]
        public void OnlyBracketsReturnsTrue1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //Want to pass
        [TestMethod]
        public void OnlyBracketsReturnsTrue2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        //Want to fail
        [TestMethod]
        public void OnlyBracketsReturnsTrue3()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("]["));
        }
        
        //Want to fail
        [TestMethod]
        public void OnlyBracketsReturnsTrue4()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("["));
        }

        //Want to pass
        [TestMethod]
        public void OnlyBracketsReturnsTrue5()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //Want to fail
        [TestMethod]
        public void OnlyBracketsReturnsTrue6()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[kldfja]adfa"));
        }

        //Want to pass
        [TestMethod]
        public void OnlyBracketsReturnsTrue7()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[test][test]"));
        }
        //Want to fail
        [TestMethod]
        public void OnlyBracketsReturnsTrue8()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[test]]test]"));
        }

    }
}
