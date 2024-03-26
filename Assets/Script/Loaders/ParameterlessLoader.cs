using UnityEngine;

public class ParameterlessLoader<T> : Loader<T>
{
    [SerializeField] GlobalList<T> _data;

    public void LoadData()
    {
        LoadData(_data);
    }
}
