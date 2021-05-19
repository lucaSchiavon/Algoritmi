using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1
{
    class HashTable
    {
       
        public class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(int k, string v)
        {

            var entry = GetEntry(k);
            if (entry != null)
            {
                entry.value = v;
                return;
            }
            GetOrCreateBucket(k).AddLast(new Entry(k, v));
          

        }
        public string Get(int k)
        {
            var entry = GetEntry(k);
            return (entry == null) ? null : entry.value;
        }

        public Entry GetEntry(int k)
        {
            var bucket = GetBucket(k);
            if (bucket != null)
            {
                foreach (Entry entry in bucket)
                {
                    if (entry.key == k)
                        return entry;
                }
            }
            return null;

        }

        public void Remove(int k)
        {
            var entry = GetEntry(k);
            if (entry == null)
                throw new Exception();

            GetBucket(k).Remove(entry);
        }

        private LinkedList<Entry> GetBucket(int k)
        { 
            return  entries[Hash(k)];
        }
        private LinkedList<Entry> GetOrCreateBucket(int key)
        {
            var index = Hash(key);
            var bucket = entries[index];
            if (bucket == null)
                entries[index] = new LinkedList<Entry>();
            return bucket;
        }

        private int Hash(int k)
        {
            return Math.Abs(k) % entries.Length;
        }
    }
}
