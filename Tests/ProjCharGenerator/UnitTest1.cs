using generator;
using System;

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
            for (int i = 0; i < 1000; i++)
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
            string s;
            int count1=0;
            int count2 = 0;
            WordGenerator gen = new WordGenerator();
            for(int i=0; i<1000; i++)
            {
                s = gen.getSym();
                if (s == "и")
                    count1++;
                if (s == "когда")
                    count2++;
            }
            Assert.IsTrue(count1 > count2);
        }
        public void Test4()
        {
            string s;
            int count1 = 0;
            int count2 = 0;
            WordGenerator gen = new WordGenerator();
            for (int i = 0; i < 1000; i++)
            {
                s = gen.getSym();
                if (s == "о")
                    count1++;
                if (s == "один")
                    count2++;
            }
            Assert.IsTrue(count1 > count2);
        }
        public void Test5()
        {
            string s;
            bool flag = false;
            BiWordGenerator gen = new BiWordGenerator();
            for(int i=0; i<1000; i++)
            {
                s = gen.getSym();
                if (s.Contains("#") == true)
                    flag = true;
            }
            Assert.IsTrue(flag == false);
        }
        public void Test6()
        {
            string s;
            bool flag = false;
            BiWordGenerator gen = new BiWordGenerator();
            for (int i = 0; i < 1000; i++)
            {
                s = gen.getSym();
                if (s.Contains(" ") == false)
                    flag = true;
            }
            Assert.IsTrue(flag == false);
        }
    }
}
