using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class GlobalList<T> : ScriptableObject
{
    [InlineEditor]
    public List<T> items = new List<T>();

    public int Count => items.Count;
    public T this[int index]
    {
        get { return items[index]; }
    }
    public List<T>.Enumerator GetEnumerator()
    {
        return items.GetEnumerator();
    }
    public void Clear()
    {
        items.Clear();
    }

    public void Add(T prefabHero)
    {
        items.Add(prefabHero);
    }

}
