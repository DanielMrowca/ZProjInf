using System.IO;
using System;

class Program
{
    static void Main()
    {
       Primes prim = new Primes();
       prim.Sum(2000000);
    }
}

public class Primes
{
    /// <summary>
    /// Sum all primes below specified number
    /// </summary>
    /// <param name="below_prime">A below number to sum primes numbers</param>
    public void Sum(int below_prime)
    {
        Int64 sum = 0;
        for(int i = 0; i < below_prime; i++)
        {
            if(isPrime(i))
                sum += i;
        }
        
        Console.WriteLine("Sum of primes below "+ below_prime + " is " + sum);
    }
    
    /// <summary>
    /// Check if specified number is a Prime number
    /// </summary>
    /// <param name="number">Number to be check</param>
    /// <return>Return true if is a Prime number</retrun>
    private bool isPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
    
        if (number % 2 == 0) return false;   
    
        for (int i = 3; i < number; i += 2)  {
           if (number % i == 0) return false;
        }
    
        return true;
    }
}
