using UnityEngine;

public class ParameterlessLoader<T> : Loader<T>
{
    [SerializeField] GlobalList<T> _data;

    public void LoadData()
    {
        //Debug.LogError($"Loader {gameObject.name} data name {_data.name} count {_data.Count}");
        LoadData(_data);
    }
}
