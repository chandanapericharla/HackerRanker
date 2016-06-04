using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
     
        int N = Convert.ToInt32(Console.ReadLine());
        int[] lis = new int[N];
        int[] array = new int[N];
                
        array[0] = Convert.ToInt32(Console.ReadLine());
        lis[0] = array[0];

        int len = 1;
        
        for(int i=1; i<N; i++){
            array[i] = Convert.ToInt32(Console.ReadLine());
            
            if(array[i] < lis[0]){
                lis[0] = array[i];
            }else if(array[i] > lis[len-1]){
                lis[len++] = array[i];                
            }else{
                int index = getCeillingPosition(lis, 0, len-1, array[i]);
                lis[index] = array[i];
            }            
        }
        
        Console.WriteLine(len);
    }
    
    private static int getCeillingPosition(int[] array, int l, int r, int value){
        while(l <= r){
            
            int mid = l + ((r-l)/2);
            
            if(array[mid] < value){
                l=mid+1;                
            }
            else if(mid-1 < 0 || array[mid - 1] < value){
                return mid;
            }
            else{
                r = mid;
            }
        }
        return -1;
    }
}