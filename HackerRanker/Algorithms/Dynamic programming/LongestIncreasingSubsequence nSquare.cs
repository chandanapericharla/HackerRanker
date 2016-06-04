using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
     
        int N = Convert.ToInt32(Console.ReadLine());
        int[] lis = new int[N];
        int[] array = new int[N];
        int max = 1;
        
        lis[0] = 1;
        array[0] = Convert.ToInt32(Console.ReadLine());
        
        for(int i=1;i<N;i++){
            array[i] = Convert.ToInt32(Console.ReadLine());
            lis[i] = 1;
            for(int j=0;j<i;j++){
                if(array[j] < array[i]){
                  lis[i] = Math.Max(lis[i], lis[j] + 1);   
                  max = Math.Max(max, lis[i]);
                }
            }
        }
        Console.WriteLine(max);
    }
}