namespace DSATest.Problems.Arrays;


public class DuplicateInteger
{
    public bool HasDuplicate(IEnumerable<int> nums) {
        var valuesDict = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            if(!valuesDict.TryAdd(num, 1))
            {
                valuesDict[num] += 1;
                Console.WriteLine(valuesDict[num]);
            }
        }
        
        return valuesDict.Values.Any(n => n is not 1);
    }
}