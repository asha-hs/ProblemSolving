using System;
using System.Collections.Generic;

// Idea here is to check we have same count of elements in both the arrays order may be different.
// Using Dictionary<int,int> to keep track of item and its count

class ReverseToMakeEqual {
  static void Main(string[] args) {
    // Call areTheyEqual() with test cases here

    int[] A = {1,2,3,4};
    int[] B = {1,2,3,2};

    Console.WriteLine(areTheyEqual(A,B));

     int[] C = {1,2,3,4};
    int[] D = {1,4,3,2};

     Console.WriteLine(areTheyEqual(C,D));
  }

  private static bool areTheyEqual(int[] arr_a, int[] arr_b) {
    // Write your code here
    bool result = true;

    int len = arr_a.Length;

    // Create Dictionary to keep track of number of occurances of each item in the array
    Dictionary<int,int> map = new Dictionary<int,int>();


    for(int i = 0; i < len; i++)
    {
      if(map.ContainsKey(arr_a[i]))
      {
        map[arr_a[i]] =  map[arr_a[i]]+1;
      }else
      {
        map[arr_a[i]] = 1;
      }

    }

    for(int i = 0; i < len; i++)
    {
      if(map.ContainsKey(arr_b[i]))
           map[arr_b[i]]--;
      else
        map[arr_b[i]] = -1;
    }
    foreach( KeyValuePair<int, int> kvp in map )
    {
      if(kvp.Value != 0) return false;
    }
    return true;
  }
}