using System;
using System.Collections.Generic;
namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string  stringsInput="";
            string queriesInput="";
            
            List<String>strings = new List<String>();
           
            List<String>queries = new List<String>();
           
    //input
            Result result= new Result();
            Console.WriteLine("input strings");
            while(stringsInput!="x"){
          stringsInput=Console.ReadLine();
          if(stringsInput!="x"){
          strings.Add(stringsInput);
          }
            }
            Console.WriteLine("input queries");
              while(queriesInput!="x"){
         queriesInput=Console.ReadLine();
          if(queriesInput!="x"){
          queries.Add(queriesInput);
          }
            }
             strings.Add("aba");
           strings.Add("baba");
           strings.Add("aba");
           strings.Add("xzxb");
            queries.Add("aba");
         queries.Add("xzxb");
           queries.Add("bab");
        List <int> ouput=result.matchingStrings(strings,queries);
          foreach(int item in ouput){
        Console.WriteLine(item);
    }
        }
    }
}
