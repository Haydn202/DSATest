using Microsoft.Extensions.Azure;

namespace DSATest.Problems.Arrays;

public class AnagramGroups
{
    public List<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, IList<string>>();
        foreach (var word in strs) {
            var hash = new string (word.OrderBy(c => c).ToArray());
            
            if (groups.TryGetValue(hash, out var value)) {
                value.Add(word);
            } else {
                groups.Add(hash, new List<string>{word});
            }
        }

        return groups.Values.ToList();
    }
}