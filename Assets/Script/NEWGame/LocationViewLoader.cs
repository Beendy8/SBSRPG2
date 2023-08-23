using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LocationViewLoader : MonoBehaviour, IDataLoader<Location>
{
    [SerializeField] LocationView _locationView;
    [SerializeField] LocationList _locations;
    [FoldoutGroup("LastLocation")]
    [SerializeField] UnityEvent _onLastLocationLoaded;
    [FoldoutGroup("FirstLocation")]
    [SerializeField] UnityEvent _onFirstLocationLoaded;
    private int _activeLocationIndex;

    private void Start()
    {
        RefreshView();
    }

    public void LoadNextLocation(int modifier)
    {
        _activeLocationIndex += modifier;

        RefreshView();
    }

    public void RefreshView()
    {
        (this as IDataLoader<Location>).LoadData(_locations[_activeLocationIndex], _locationView);

        if (_activeLocationIndex == 0)
            _onFirstLocationLoaded.Invoke();

        if (_activeLocationIndex == _locations.Count - 1)
            _onLastLocationLoaded.Invoke();
    }

}
