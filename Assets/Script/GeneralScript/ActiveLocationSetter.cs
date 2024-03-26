using Sirenix.OdinInspector;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;

public class ActiveLocationSetter : MonoBehaviour
{
    [SerializeField] LocationList _locations;
    [FoldoutGroup("LastLocation")]
    [SerializeField] UnityEvent _onLastLocationLoaded;
    [FoldoutGroup("FirstLocation")]
    [SerializeField] UnityEvent _onFirstLocationLoaded;
    [FoldoutGroup("ActiveLocation")]
    [SerializeField] UltEvent<Location> _onSetActiveLocation;
    private int _activeLocationIndex;

    private void Start()
    {
        SetActiveLocation(0);
    }

    public void SetActiveLocation(int value)
    {
        _activeLocationIndex = value;

        if (_activeLocationIndex == 0)
            _onFirstLocationLoaded.Invoke();

        if (_activeLocationIndex == _locations.Count - 1)
            _onLastLocationLoaded.Invoke();

        _onSetActiveLocation.Invoke(_locations[_activeLocationIndex]);
    }

    public void ModifyActiveLocation(int modifier)
    {
        SetActiveLocation(_activeLocationIndex + modifier);
    }

}

