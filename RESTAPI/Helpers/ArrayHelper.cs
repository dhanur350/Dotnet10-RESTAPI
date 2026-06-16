namespace RESTAPI.Helpers
{
  public static class ArrayHelper
  {
    public static int SumofEvenNumbers(int[] numbers)
    {
      int sum = 0;
      foreach (int num in numbers)
      {
        if (num % 2 == 0)
        {
          sum += num;
        }
      }
      return sum;
    }
  }
}