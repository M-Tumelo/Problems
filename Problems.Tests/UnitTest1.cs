using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
Program Test1 = new Program();
string tester=Test1.Prefix("hello");
Assert.AreEqual("5,1:hello",tester);
            Assert.Pass();
        }
         public void Test2()
        {
Program Test2 = new Program();
string tester1=Test2.Prefix("what ... did you say??");
Assert.AreEqual("27,5:what ... did you say?? ",tester1);
            Assert.Pass();
        }
         public void Test3()
        {
Program Test3 = new Program();
string tester2=Test3.Prefix("");
Assert.AreEqual("0,0:",tester2);
            Assert.Pass();
        }
    }
    
}