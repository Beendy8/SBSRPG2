using UnityEngine;

public interface IDataLoader<T> 
{
    public void LoadData(T data, IView<T> view)
    {
        view.ViewData(data);
        Debug.Log($"�������� ���������� ����� - ���� ������ {data} � �������� {view}");
    }
    
}
