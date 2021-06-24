
using System;
using System.Collections.Generic;

class Result{

public List<int> matchingStrings(List<string>strings,List<string>queries){
List<int>output= new List<int> ();
    foreach(string item in queries){
        int count=0;
    //Console.WriteLine(item);
        foreach(string i in strings){
           // Console.WriteLine(i);
            if(item==i){
                count++;
            }
        }
        output.Add(count);
    }
    Console.WriteLine(strings.Count);
    printListString(strings);
    Console.WriteLine(queries.Count);
    printListString(queries);
return output;
}

static void printListString(List <string> i){
    foreach(string item in i){
        Console.WriteLine(item);
    }
}



}