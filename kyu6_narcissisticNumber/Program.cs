// A Narcissistic Number (or Armstrong Number) is a positive number which is 
// the sum of its own digits, each raised to the power of the number of digits 
// in a given base. In this Kata, we will restrict ourselves to decimal (base 10).

// For example, take 153 (3 digits), which is narcissistic:

// 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

// and 1652 (4 digits), which isn't:

// 1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938

// The Challenge:

// Your code must return true or false (not 'true' and 'false') depending upon 
// whether the given number is a Narcissistic number in base 10.

// This may be True and False in your language, e.g. PHP.

// Error checking for text strings or other invalid inputs is not required, only 
// valid positive non-zero integers will be passed into the function.



// public class Kata
// {
//   public static bool Narcissistic(int value)
//   {



    // Code me
    int HowManyNumbers (int inputNumber)
    {
        //int nurrastic = 0;
        int numberOfDigits = 0;
        while (inputNumber > 0)
        {
            inputNumber = inputNumber/10;
            numberOfDigits++;
        }
        return numberOfDigits;
    }

    int Expon(int inputNumber, int numOfDigits)
    {
        int nurr = 0;// new int();
        int step = 1;//new int();
        int ost = new int();
        while(inputNumber > 0)
        {
            ost = inputNumber%10;
            //step = Convert.ToInt32(Math.Pow(ost, numOfDigits)); //don't now how to use it in code wars

            for(int i=1; i<=numOfDigits; i++)
            {
                step = step*ost;
            }
            nurr = nurr + step;
            inputNumber = inputNumber/10;
            step = 1;
        }
        return nurr;
    }

    Console.Clear();
    Console.WriteLine("Введите число: ");   //for local code
    int value = int.Parse(Console.ReadLine());  //for local code
   // Console.WriteLine(value);    //check input number

    int digits = HowManyNumbers(value);
    //Console.WriteLine(digits);    //check counting digits

    int nurrastic = Expon (value, digits);
    Console.WriteLine(nurrastic);   //check how it is counting

    if (value == nurrastic)
    {
        //return true;
        Console.WriteLine("Number is Nurrastic"); //for local code
    }
    else 
    {
        //return false;
        Console.WriteLine("Number is not Nurrastic");    //for local code
    }



//   }
// }





