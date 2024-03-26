using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GlobalList<T> : GlobalList, ISaveable
{
    [InlineEditor]
    public List<T> items = new List<T>();

    public event Action<ISaveable> onChange;
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
        onChange?.Invoke(this);
    }
    public void Add(T prefabHero)
    {
        items.Add(prefabHero);
        onChange?.Invoke(this);
    }
    public void AddRange(IEnumerable<T> _items)
    {
        items.AddRange(_items);
        onChange?.Invoke(this);
    }
    public void Modify(int index, T value)
    {
        items[index] = value;
        onChange?.Invoke(this);
    }
    public bool Contains(T targetItem)
    {
        return items.Contains(targetItem);
    }
    public static implicit operator List<T>(GlobalList<T> globalList)
    {
        return globalList.items;
    }
}
public class GlobalList: ScriptableObject, ISaveable
{
    public event Action<ISaveable> onChange;

}