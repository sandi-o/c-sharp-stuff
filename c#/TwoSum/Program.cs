using System.Globalization;
using System.Security.Cryptography.X509Certificates;

int[] TwoSum(int[] nums, int target)
{
    //Solution 1:
    // loop each element of nums array (except for the current element)
    // add the current element to each of nums array and check if the sum will be equal to the target
    // if the sum is equal to the target return the current element index (i) and the other index (j)
    // otherwise, return an empty int array
    // for(int i = 0; i < nums.Length; i++)
    // {
    //     Console.WriteLine($"nums i: {nums[i]}");
    //     for(int j = i + 1; j < nums.Length; j++)
    //     {
    //         Console.WriteLine($"num j: {nums[j]}");
    //         if( target == (nums[i] + nums[j]))
    //             return new int [] {i, j};
    //     }
    // }

    //if we wanted to optimise further
    //Solution 2:
    // loop each element of nums array
    // subtract the element (of the current index [y]) to the target
    // check if the difference [x] is in the map dictionary
    // if not in map dictionary then add to map else return in array as we already have found the answer
    // note since x and y equals to the target, we are solving for x to in order to find if the current index [y] and the difference [x]
    // are both in the array
    Dictionary<int, int> map = new Dictionary<int, int>();
    
    for(int i = 0; i < nums.Length; i++)
    {
        //x + y = target
        //x = target - y
        int x = target - nums[i];
        if(map.ContainsKey(x))
        {
            return new int[] {i, map[x]};
        }

        map.Add(x, i);
    }

    return new int[] {};
}

Console.WriteLine("[{0}]",string.Join(",",TwoSum([11,4,3,5,4], 8)));