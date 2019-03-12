using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTable
{
    class RoundTable<T> : IComparable<T> , IEnumerable<T>
    {
        private List<T> entities;
        public RoundTable()
        {
            entities = new List<T>();
        }

        public void Add(T entitie)
        {
            entities.Add(entitie);
        }
        public void RemoveAt(int index)
        {
            if (index <= entities.Count)
            {
                entities.RemoveAt(index);
            }
            entities.RemoveAt(index - entities.Count);
        }

        public void Clear()
        {
            entities.Clear();
        }
        public void InsertAt(int index, T hero)
        {
            if(index <= entities.Count)
            {
                entities.Insert(index, hero);
            }
            entities.Insert(index-1 - entities.Count, hero);
           
        }
        public void Sort()
        {
            entities.Sort();
        }
        public List<T> GetRounded(int index)
        {
            List<T> newEntities = new List<T>;
            while(index <= entities.Count)
            {
                foreach (T hero in entities)
                {
                    newEntities = hero
                }             
            }
            return;
        }
        public List<T> this[int index]
        {
            get
            {
                   if (index<= entities.Count)
                {
                    return entities[index];
                } 
            }
        }
        public string this[string name]
        {
            get
            {

            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(T other)
        {
            return 
        }

        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }
    }
}
