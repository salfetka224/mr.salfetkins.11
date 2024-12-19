using System.Collections.Generic;

public class Cache
{
    private static Dictionary<string, object> _cache = new Dictionary<string, object>();

    public static void Add(string key, object value)
    {
        _cache[key] = value;
    }

    public static object Get(string key)
    {
        return _cache.ContainsKey(key) ? _cache[key] : null;
    }
}