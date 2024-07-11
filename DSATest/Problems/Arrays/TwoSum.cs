using System.Reflection.Metadata.Ecma335;

namespace DSATest.Problems.Arrays;

public class TwoSum
{
    public int[] GetTwoSum(int[] nums, int target)
    {
        var numDict = new Dictionary<int, int>();
        var index = 0;

        foreach (var num in nums)
        {
            if (numDict.ContainsKey(target - num))
            {
                return new int[] {numDict[target - num], index};
            }
            
            numDict.Add(num, index);
            index++;
        }

        return null;
    }
}