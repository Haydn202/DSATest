using Microsoft.Extensions.Azure;

namespace DSATest.Problems.Arrays;

public class AnagramGroups
{
    public List<IList<string>> GroupAnagrams(IEnumerable<string> strs) {
        var groups = new Dictionary<string, IList<string>>();
        foreach (var word in strs) {
            var hash = string.Concat(word.OrderBy(c => c));
            
            if (groups.TryGetValue(hash, out var value)) {
                value.Add(word);
            } else {
                groups.Add(hash, [word]);
            }
        }

        return groups.Values.ToList();
    }
}