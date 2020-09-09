using System;


using c_sharp;
using NUnit.Framework;

using System.Collections.Generic;

namespace PrimeService.Tests
{
    public class UnitTest1
    {




        [Test]
        public void Test1()
        {

            var D = new Dictionary<string, int>() { { "2020-4-13", 1 }, { "2020-4-14", 4 }, { "2020-4-15", 9 }, { "2020-4-16", 2 }, { "2020-4-17", 3 }, { "2020-4-19", 1 }, { "2020-4-20", 1 } };
            var test_value = new Dictionary<string, int>() { { "Monday", 2 }, { "Tuesday", 4 }, { "Wednesday", 9 }, { "Thursday", 2 }, { "Friday", 3 }, { "Saturday", 2 }, { "Sunday", 1 } };

            var result1 = c_sharp.Program.Solution(D);


            Assert.AreEqual(result1, test_value);


        }
        [Test]
        public void Test2()
        {

            var D = new Dictionary<string, int> () { { "2020-4-15", 3 }, { "2020-4-10", 9 }, { "2020-4-16", 2 }, { "2020-4-17", 3 }, { "2020-4-19", 1 }, { "2020-4-20", 1 }, { "2020-4-21", 8 },{ "2020-4-22", 2 } };
              var test_value = new Dictionary<string, int>() { { "Monday", 1 }, { "Tuesday", 8 }, { "Wednesday", 5 }, { "Thursday", 2 }, { "Friday", 12 }, { "Saturday", 6 }, { "Sunday", 1 } };

            var result1 = c_sharp.Program.Solution(D);


            Assert.AreEqual(result1, test_value);


        }
        [Test]
        public void Test3()
        {

           var D = new Dictionary<string, int> () { { "2020-4-1", 3 }, { "2020-4-16", 3 }, { "2020-4-12", 5 }, { "2020-4-2", 1 }, { "2020-4-21", 8 },{ "2020-4-22", 2 },{ "2020-4-20", 1 }  };
            var test_value = new Dictionary<string, int>() { { "Monday", 1 }, { "Tuesday",8 }, { "Wednesday", 5 }, { "Thursday", 4 }, { "Friday", 2 }, { "Saturday", 3 }, { "Sunday", 5 } };

            var result1 = c_sharp.Program.Solution(D);


            Assert.AreEqual(result1, test_value);


        }
    }
}
