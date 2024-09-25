using System.Runtime.InteropServices.JavaScript;

namespace DSA.Linear;

public class HashTable<TK, TV>(int size)
{
    private Array _data = new TK[size];

    public void Set(TK key, TV value)
    {
        
    }

    private int Hash(TK key)
    {
        return key.GetHashCode();
    }
}