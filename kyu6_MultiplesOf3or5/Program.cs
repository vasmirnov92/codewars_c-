// If we list all the natural numbers below 10 that are multiples 
// of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

// Finish the solution so that it returns the sum of all the multiples 
// of 3 or 5 below the number passed in. Additionally, if the number is negative, 
// return 0 (for languages that do have them).

// Note: If the number is a multiple of both 3 and 5, only count it once.

// Courtesy of projecteuler.net (Problem 1)


public static class Kata
{
  public static int Solution(int value)
  {
    // Magic Happens


        int CountMultiplies(int number)
        {
            int summMultiplies = new int();
            for (int i=1; i<number; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    summMultiplies += i;
                }
            }
            return summMultiplies;
        }

        //Console.Clear();    //for local check
        //Console.WriteLine("Insert number:");    //for local check
        //int value = int.Parse(Console.ReadLine());  //for local check
        //Console.WriteLine(value);   // check insert

        int summ = CountMultiplies(value);
        //Console.WriteLine(summ);    //for local check
        return summ;



  }
}
