
namespace ODM
{
    using System.Collections.Generic;
    using UnityEngine;

    public class DataManager : MonoBehaviour
    {
        Dictionary<string, object> storage = new Dictionary<string, object>();
        
        void Awake ()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        public void Put(string key, object data)
        {
            storage[key] = data;
        }

        public object Get(string key)
        {
            return storage[key];
        }

        public bool Has(string key)
        {
            return storage.ContainsKey(key);
        }

        public void Delete(string key)
        {
            storage.Remove(key);
        }
    }
}
