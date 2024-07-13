namespace DSATest.Problems.HashTables;

public abstract class FirstRecurringChar
{
    public static int? GetFirstRepeatingChar(int[] nums)
    {
        var charSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!charSet.Add(num))
            {
                return num;
            }
        }

        return null;
    }
}