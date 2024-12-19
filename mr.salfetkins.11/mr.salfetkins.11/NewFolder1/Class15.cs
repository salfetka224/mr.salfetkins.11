using System;
using System.Collections.Generic;

public class Cacher 
{
    private static Dictionary<string, CacheItem> _cache = new Dictionary<string, CacheItem>();

    public class CacheItem
    {
        public object Value { get; set; }
        public DateTime Expiry { get; set; }

        public bool IsExpired()
        {
            return DateTime.Now > Expiry;
        }
    }

    public static void Add(string key, object value, TimeSpan ttl)
    {
        _cache[key] = new CacheItem
        {
            Value = value,
            Expiry = DateTime.Now.Add(ttl)
        };
    }

    public static object Get(string key)
    {
        if (_cache.ContainsKey(key))
        {
            var item = _cache[key];
            return item.IsExpired() ? null : item.Value;
        }
        return null;
    }
}