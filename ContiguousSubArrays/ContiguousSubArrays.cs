using System;


class ContiguousSubArrays {
  static void Main(string[] args) {
    // Call countSubarrays() with test cases here
    int[] arr = new int[] {3,4,1,6,2};
  //  int[] array1 = new int[] { 1, 3, 5, 7, 9 };
    int[] res = new int[arr.Length];
    res = countSubarrays(arr);

    for(int i = 0; i < res.Length; i++)
    {
      Console.Write(res[i] + " ");
    }

    Console.WriteLine("\n");

  }

  private static int[] countSubarrays(int[] arr) {
    // Write your code here

    int len = arr.Length;

    int[] result = new int[len];
    int count = 0;
    for(int i = 0; i<len; i++)
    {
      count = 1;
      for(int j = i+1; j<len; j++)
      {
        if(arr[i] > arr[j])
        {
          count++;
        }
        else{
          break;
        }
      }

      if(i >0)
      {
        for(int k = i-1; k >= 0; k--)
        {
          if(arr[i] > arr[k])
          {
            count++;
          }else {
            break;
          }
        }
      }
      result[i] = count;
    }
    return result;
  }
}