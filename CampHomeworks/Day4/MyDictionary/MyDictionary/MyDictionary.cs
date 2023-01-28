using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKey, TValue>
    {
        KeyValuePair<TKey, TValue>[] pairs;

        public MyDictionary()
        {
            pairs = new KeyValuePair<TKey, TValue>[0];
        }

        public void Add(TKey key, TValue value)
        {
            if (IsKeyExists(key) == false)
            {
                KeyValuePair<TKey, TValue>[] tempPairs = pairs;
                pairs = new KeyValuePair<TKey, TValue>[pairs.Length + 1];

                for (int i = 0; i < tempPairs.Length; i++)
                {
                    pairs[i] = tempPairs[i];
                }

                pairs[pairs.Length - 1] = new KeyValuePair<TKey, TValue>(key, value);
            }
            else
            {
                Console.WriteLine("Girilen key değeri zaten mevcut.");
            }
        }

        private bool IsKeyExists(TKey key)
        {
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i].Key.ToString().Equals(key.ToString()))
                {
                    return true;
                }     
            }

            return false;
        }

        public void ListAll()
        {
            foreach(KeyValuePair<TKey, TValue> pair in pairs)
            {
                Console.WriteLine("Key: " + pair.Key + " Value: " + pair.Value);
            }
        }
    }

}
