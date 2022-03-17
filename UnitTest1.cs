using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Operator_overriding()
        {
            Lab_1.fraction a = new Lab_1.fraction(2, 3);
            Lab_1.fraction b = new Lab_1.fraction(2, 3);

            Lab_1.fraction c = a + b;
            Assert.AreEqual("12/9", c.ToString());
            Lab_1.fraction d = a - b;
            Assert.AreEqual("0/0", d.ToString());
            Lab_1.fraction e = a / b;
            Assert.AreEqual("6/6", e.ToString());
            Lab_1.fraction f = a * b;
            Assert.AreEqual("4/9", f.ToString());
        }
            }
}
