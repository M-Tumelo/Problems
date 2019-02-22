using NUnit.Framework;
using Problems;
using System.Collections;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public class MyTests
        {
            [TestCaseSource(typeof(MyDataClass), "TestCases")]
            public string Prefix(string h)
            {
                int s = h.Length;
                string[] delimters = new string[] { " " };
                string[] arr = h.Split(delimters, StringSplitOptions.RemoveEmptyEntries);

                if (h != "")
                {
                    h = $"{s},{arr.Length}:" + h;
                }
                else h = "0,0:";
                return h;
            }
        }

        public class MyDataClass
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData("Hello").Returns("5,1:Hello");
                    yield return new TestCaseData("").Returns("0,0:");
                    yield return new TestCaseData("what   ...  did you say??  ").Returns("27,5:what   ...  did you say??  ");
                    yield return new TestCaseData("Oh My Word! ").Returns("12,3:Oh My Word! ");
                    yield return new TestCaseData("WOW").Returns("3,1:WOW");
                }
            }
        }

    }

}
