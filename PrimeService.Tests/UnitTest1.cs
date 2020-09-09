using System;


using c_sharp;
using  NUnit.Framework;

using System.Collections.Generic;

namespace PrimeService.Tests
{
    public class UnitTest1
    {   

    
      

        [Test] 
        public void Test1()
        {   
            //  c_sharp   p = new c_sharp();
            
            var D = new Dictionary<string, int> () { { "2020-4-13", 1 }, { "2020-4-14", 4 }, { "2020-4-15", 9 }, { "2020-4-16", 2 }, { "2020-4-17", 3 }, { "2020-4-19", 1 }, { "2020-4-20", 1 } };
            //
             var test_value = new Dictionary<string, int> () {{"Monday",2},{"Tuesday",4},{"Wednesday",9},{"Thursday",2},{"Friday",3},{"Saturday",2},{"Sunday",1}};
         
          var result = c_sharp.Program.Solution(D);

        Assert.AreEqual(result,test_value);

        }
    }
}
