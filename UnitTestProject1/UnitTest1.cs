using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1 = 0,x2=0,x3=4,y1=0,y2=3,y3=0;
            double a = ConsoleApp1.Program.distance(x1, x2, y1, y2);
            double b = ConsoleApp1.Program.distance(x1, x3, y1, y3);
            double c = ConsoleApp1.Program.distance(x2, x3, y2, y3);
            double P = ConsoleApp1.Program.perimeter(a, b, c);
            double S = ConsoleApp1.Program.area(a, b, c, P);
            Assert.AreEqual(12, P);
            Assert.AreEqual(6, S);
        }
    }
}
