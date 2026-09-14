//Challenge: Given an integer n, return the number of prime numbers that are strictly less than n.
int CountPrime(int n)
{
    //create a dictionary that contains all number from 0 to n;
    //assume all numbers are prime
    //0 and 1 are prime not prime numbers
    Dictionary<int,bool> nums = new Dictionary<int, bool>();
    for(int i = 1; i <= n; i++)
    {
        nums[i] = true;
    }

    for(int i = 1; i < Math.Sqrt(n); i++)
    {
        
        if (i == 0 || i == 1)
        {
            nums[i] = false;
        } else
        {
            for(int j = i*i;j <= n;j+=i)
            {
                nums[j] = false;    
            }            
        }
        Console.WriteLine($"Key: {i}, Val: {nums[i]}");
    }
    
    return nums.Count( v =>v.Value == true);
}


Console.WriteLine(CountPrime(100));

