﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
using System.Xml;
using System.Xml.Serialization;

namespace c_sharp {
    class Program {

        public static  Dictionary<string, int> Solution (Dictionary<string, int> D) {

           
            var dict = new Dictionary<string, int> () { { "Monday", 0 }, { "Tuesday", 0 }, { "Wednesday", 0 }, { "Thursday", 0 }, { "Friday", 0 }, { "Saturday", 0 }, { "Sunday", 0 } };

            
            foreach (var item in D) {
                DateTime dt;

                DateTime.TryParse (item.Key, out dt);

                var newVal = dt.ToString ("dddd");

                dict[newVal] += item.Value;

            }
            for (int i = 0; i < dict.Count; i++) {

                //    
                if (dict.ElementAt (i).Value == 0) {
                    // do the average here
                    //  dict.ElementAt(i).Value=((dict.ElementAt(i-1).Value+dict.ElementAt(i+1).Value))/2;
                    string noneValueDay = dict.ElementAt (i).Key;
                    int meanValue = ((dict.ElementAt (i - 1).Value + dict.ElementAt (i + 1).Value)) / 2;
                    dict[noneValueDay] = meanValue;
                    

                }

            }
         

           return dict;

        }

        public static void Main (string[] args) {
            var D = new Dictionary<string, int> () { { "2020-4-13", 1 }, { "2020-4-14", 4 }, { "2020-4-15", 9 }, { "2020-4-16", 2 }, { "2020-4-17", 3 }, { "2020-4-19", 1 }, { "2020-4-20", 1 } };
            var D2 = new Dictionary<string, int> () { { "2020-4-15", 3 }, { "2020-4-10", 9 }, { "2020-4-16", 2 }, { "2020-4-17", 3 }, { "2020-4-19", 1 }, { "2020-4-20", 1 }, { "2020-4-21", 8 },{ "2020-4-22", 2 } };
            var D3 = new Dictionary<string, int> () { { "2020-4-1", 3 }, { "2020-4-16", 3 }, { "2020-4-12", 5 }, { "2020-4-2", 1 }, { "2020-4-21", 8 },{ "2020-4-22", 2 },{ "2020-4-20", 1 }  };
          
            //
            var result=Solution(D3);
            foreach (var item in result){
                 Console.Write("{0}:{1} ,",item.Key,item.Value);
               
            }
            {
                
            }

        }

    }
}
