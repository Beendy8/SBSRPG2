using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class CharacterViewsLoader : MonoBehaviour, IDataLoader<Character>
{
    [SerializeField] GameObject _viewPrefab;
    [SerializeField] Transform _viewsParent;
    [SerializeField] Character[] _characters;
    [HideInInspector]
    [SerializeField] List<GameObject> _views = new();

#if UNITY_EDITOR
    [Button]
    public void LoadIcons()
    {
        foreach (var view in _views)
        {
            if (view != null)
                DestroyImmediate(view.gameObject);
        }

        _views.Clear();

        foreach (var hero in _characters)
        {
            GameObject view = Instantiate(_viewPrefab, _viewsParent);
            view.SetActive(true);
            _views.Add(view);
            (this as IDataLoader<Character>).LoadData(hero, view.GetComponent<IView<Character>>());
        }
    }
#endif
}
