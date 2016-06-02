using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int testCasesCount = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < testCasesCount; i++)
        {
           string[] tokens_n = Console.ReadLine().Split(' ');
           int n = Convert.ToInt32(tokens_n[0]);
           int m = Convert.ToInt32(tokens_n[1]);
           
           if(m == 1 || n % 2 == 0)
           {
               Console.WriteLine("2");
           }
           else {
               Console.WriteLine("1");
           } 
        }
    }
}