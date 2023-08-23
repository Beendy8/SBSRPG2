using UnityEngine;

public interface IDataLoader<T> where T : ScriptableObject
{
    public void LoadData(T data, IView<T> view)
    {
        view.ViewData(data);
    }
}
