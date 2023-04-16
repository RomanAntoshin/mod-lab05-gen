using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using лаб_5;
using lab_5;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tuple<char, char> tuple = new Tuple<char, char>('ь', 'ь');
            BiCharGenerator gen = new BiCharGenerator();
            for(int i=0; i<1000; i++)
                Assert.IsTrue(gen.getSym() != tuple);
        }
        public void TestMethod2()
        {
            Tuple<char, char> tuple = new Tuple<char, char>('б', 'б');
            BiCharGenerator gen = new BiCharGenerator();
            for (int i = 0; i < 1000; i++)
                Assert.IsTrue(gen.getSym() != tuple);
        }
        public void TestMethod3()
        {
           //Wo
        }
    }
}
