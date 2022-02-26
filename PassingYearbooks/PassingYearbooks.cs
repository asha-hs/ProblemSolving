using System;


class PassingYearbooks {
  static void Main(string[] args) {
    // Call findSignatureCounts() with test cases here
    int[] arr = {1,2};
    int[] res = new int[2];

    res = findSignatureCounts(arr);
    for(int i = 0; i < 2; i++)
    {
      Console.WriteLine(res[i]);
    }

  }

  private static int[] findSignatureCounts(int[] arr) {
    // Write your code here
    int len = arr.Length;
    int[] signatureCount = new int[len];



    for(int i = 1; i <= len; i++)
    {
      int bookOwner = i;
      int currentHolder = i;

      do {
        signatureCount[i-1] += 1;
        currentHolder = arr[currentHolder-1];
      }while(currentHolder != bookOwner);
    }

    return signatureCount;
  }
}