using UnityEngine;

public class DataStorage<T> : ScriptableObject
{
    [SerializeField] T _data;
    public T data => _data;
    public void SetData(T data)
    {
        _data = data;
    }

    public static implicit operator T(DataStorage<T> storage)
    {
        return storage.data;
    }
}
