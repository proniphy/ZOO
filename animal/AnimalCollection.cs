using System.Collections;

namespace Zoo
{
    /// <summary>
    /// Generic container for animals that allows extracting subsets based on type
    /// </summary>
    class AnimalCollection : IEnumerable<Animal>
    {
        private Dictionary<Type, List<Animal>> listsPerType;
        private int totalCount = 0;

        public int Count { get => totalCount; }

        public AnimalCollection()
        {
            listsPerType = new Dictionary<Type, List<Animal>>();
        }

        public AnimalCollection(IEnumerable<Animal> initial)
            : this()
        {
            foreach (Animal a in initial)
            {
                Add(a);
            }
        }

        private void RecountAndPruneLists()
        {
            totalCount = 0;
            var prune = new List<Type>();
            foreach ((Type t, var l) in listsPerType)
            {
                if (l.Count > 0)
                {
                    totalCount += l.Count;
                }
                else
                {
                    prune.Add(t);
                }
            }
            foreach (Type t in prune)
            {
                listsPerType.Remove(t);
            }
        }

        public void Add(Animal animal)
        {
            Type t = animal.GetType();
            if (listsPerType.ContainsKey(t))
            {
                listsPerType[t].Add(animal);
            }
            else
            {
                listsPerType[t] = new List<Animal>([animal]);
            }
            totalCount += 1;
        }

        public bool Remove(Animal animal)
        {
            bool removed = false;
            Type t = animal.GetType();
            if (listsPerType.ContainsKey(t))
            {
                removed = listsPerType[t].Remove(animal);
            }
            RecountAndPruneLists();
            return removed;
        }

        public int RemoveAll(Predicate<Animal> predicate)
        {
            int removed = 0;
            foreach ((_, var list) in listsPerType)
            {
                removed += list.RemoveAll(predicate);
            }
            RecountAndPruneLists();
            return removed;
        }

        public List<T> GetAnimalsOfType<T>(bool includeSubclasses = true) where T : Animal
        {
            var result = new List<T>();
            foreach ((Type t, var list) in listsPerType)
            {
                if (t == typeof(T))
                {
                    foreach (Animal a in list)
                    {
                        result.Add((T)a);
                    }
                }
                else if (includeSubclasses && t.IsSubclassOf(typeof(T)))
                {
                    foreach (Animal a in list)
                    {
                        result.Add((T)a);
                    }
                }
            }
            return result;
        }

        public List<Type> GetContainedAnimalTypes()
        {
            var result = new List<Type>();
            foreach ((Type t, _) in listsPerType)
            {
                result.Add(t);
            }
            return result;
        }

        public bool HasAnyAnimalOfType<T>(bool includeSubclasses = true) where T : Animal
        {
            foreach ((Type t, var list) in listsPerType)
            {
                if (t == typeof(T) && list.Count > 0)
                {
                    return true;
                }
                else if (includeSubclasses && t.IsSubclassOf(typeof(T)) && list.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public struct Enumerator : IEnumerator<Animal>
        {
            private IEnumerator<KeyValuePair<Type, List<Animal>>> dictEnum;
            private IEnumerator<Animal>? currentListEnum = null;

            public Enumerator(AnimalCollection collection)
            {
                dictEnum = collection.listsPerType.GetEnumerator();
            }

            public bool MoveNext()
            {
                if (currentListEnum != null && currentListEnum.MoveNext())
                {
                    return true;
                }
                else
                {
                    while (dictEnum.MoveNext())
                    {
                        currentListEnum = dictEnum.Current.Value.GetEnumerator();
                        if (currentListEnum.MoveNext())
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public void Reset()
            {
                dictEnum.Reset();
                currentListEnum = null;
            }

            public void Dispose() {}

            public Animal Current => currentListEnum?.Current;
            object IEnumerator.Current => Current;
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
