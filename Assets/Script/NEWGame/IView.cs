using UnityEngine;

public interface IView<T> where T : ScriptableObject
{
    public void ViewData(T data);
}
