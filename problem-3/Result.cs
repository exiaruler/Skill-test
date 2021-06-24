using System;
using System.Linq;
using System.Collections;
 class Result { 

    public string timeConversion(string s){
  
        //split string
            string [] split = s.Split(":");
            
            int splitLength=split.Length;
            //split end
            string timeOfDay="";
            string second="";
            // check each value and allocate
              foreach (char i in split[2]){
               if(checkforChar(i)){
                 timeOfDay+=i;
               }else {
                  second+=i;
               }
           }
           
         //create array list
         ArrayList time = new ArrayList();
         // check if hour is 12
        if(timeOfDay.ToUpper()=="PM"){
            int convert=Int16.Parse(split[0]);
            if(convert!=12){
            convert=convert+12;
            split[0]=convert.ToString();
            } 
           
        }
        if(timeOfDay.ToUpper()=="AM"){
         int convert=Int16.Parse(split[0]);
         if(split[0]=="12"){
             split[0]="00";
         }
            
        }
            time.AddRange(split);
         // delete end of split to remove e.g 00AM
        time.RemoveAt(2);
        time.Add(second);
       string result ="";
       // add string to result from array list
        foreach(Object item in time){
            
            result+=item;
            result+=":";
        }
        //trim end  
        char [] variables ={':'};
        result= result.TrimEnd(variables);
       // Console.WriteLine(result);
      
        return result; 

       
    }

    // sorting for end of string that contains the time of day and seconds
    static bool checkforChar(char ele){
        char [] letters ={'P','M','A'};
        ele = char.ToUpper(ele);
        for(int t=0; t<letters.Length; t++){
            if(ele==letters[t]){
                return true;
            }
        }
        return false;
    }
    
    // view array content
    static void print(string[] arr){
        for(int i=0; i<arr.Length; i++){
            Console.WriteLine(arr[i]);
        }
    }



    
    


   


 }
