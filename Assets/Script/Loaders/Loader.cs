using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Loader<T> : MonoBehaviour
{
    [FormerlySerializedAs("_viewsTransform")]
    [SerializeField] Transform _viewsParent;
    [SerializeField] protected List<GameObject> _views;
    public List<GameObject> views => _views;
    [SerializeField] GameObject _viewPrefab;

    public void LoadData(List<T> data)
    {
        for (int i = 0; i < data.Count; i++)
            LoadDataElement(data[i], i);
    }
    public void LoadDataElement(T data, int index)
    {
        if (data == null)
        {
            Debug.LogWarning($"В процессе загрузки данных {name} получил список с пустым элементом под индексом {index}", gameObject);
            return;
        }

        if (_views.Count <= index)
        {
            var gameObject = Instantiate(_viewPrefab, _viewsParent);
            _views.Add(gameObject);
        }

        _views[index].SetActive(true);
        _views[index].GetComponent<IView<T>>().ViewData(data);
        
    }

}
