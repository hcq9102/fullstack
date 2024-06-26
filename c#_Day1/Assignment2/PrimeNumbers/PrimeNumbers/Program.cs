static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();

    for (int num = startNum; num <= endNum; num++)
    {
        if (IsPrime(num))
        {
            primes.Add(num);
        }
    }

    return primes.ToArray();
}

static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    if (number == 2)
    {
        return true;
    }
    if (number % 2 == 0)
    {
        return false;
    }

    int endValue = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= endValue; i += 2)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}

int startNum = 1;
int endNum = 20;

int[] primes = FindPrimesInRange(startNum, endNum);

Console.WriteLine("Prime numbers in range {0} to {1}:", startNum, endNum);
foreach (int prime in primes)
{
    Console.WriteLine(prime);
}
