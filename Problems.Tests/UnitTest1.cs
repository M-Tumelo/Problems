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
            string tester = Test1.Prefix("hello");
            string tester1 = Test1.Prefix("what   ...  did you say??  ");
            string tester2 = Test1.Prefix("");
            Assert.AreEqual("0,0:", tester2);
            Assert.AreEqual("27,5:what   ...  did you say??  ", tester1);
            Assert.AreEqual("5,1:hello", tester);
            Assert.Pass();
        }

    }

    public class Tests2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2()
        {
            Program Test2 = new Program();
            string tester1 = Test2.Prefix("WOW");
            string h = Test2.Prefix("Oh My Word! ");
            Assert.AreEqual("12,3:Oh My Word! ", h);
            Assert.AreEqual("3,1:WOW", tester1);
            Assert.Pass();
        }

    }
    public class Tests3
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test3()
        {
            Program Test3 = new Program();
            string tester1 = Test3.Prefix("As it begins");
            string test = Test3.Prefix("With a default");
            Assert.AreEqual("12,3:As it begins", tester1);
            Assert.AreEqual("14,3:With a default", test);
            Assert.Pass();
        }
    }
}
