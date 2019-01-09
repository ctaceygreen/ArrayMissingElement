using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        HashSet<int> numberExists = new HashSet<int>();
        foreach(var item in A)
        {
            numberExists.Add(item);
        }
        for(int i = 1; i <= A.Length + 1; i++)
        {
            if(!numberExists.Contains(i))
            {
                return i;
            }
        }
        return 0;
    }
}