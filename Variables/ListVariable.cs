using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameBlocks.Variables
{
	public abstract class ListVariable<T> : ScriptableObject
    {
        public List<T> Items = new List<T>();

        public int Count { get { return Items.Count; } }

        public void Add(T thing)
        {
            if (!Items.Contains(thing))
            {
                Items.Add(thing);
            }
            else
            {
                Items.Remove(thing);
                Items.Add(thing);
            }
        }

        public void Remove(T thing)
        {
            if (Items.Contains(thing))
                Items.Remove(thing);
        }

        public void Clear()
        {
            Items.Clear();
        }

        public bool Contains(T item)
        {
            return Items.Contains(item);
        }
        
        public void Reverse()
        {
            Items.Reverse();
        }

        public T Get(int i)
        {
            return Items[i];
        }

        public List<T> List
        {
            get { return Items; }
            set { Items = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                return Items[index];
            }
            set
            {
                Items[index] = value;
            }
        }
    }
}