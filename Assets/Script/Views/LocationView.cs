using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LocationView : MonoBehaviour, IView<Location>
{
    [SerializeField] Image background;
    Location _location;
    [SerializeField] UnityEvent<List<Level>> _onView;

    public void ViewData(Location data)
    {
        _location = data;
        background.sprite = _location.background;
        _onView.Invoke(_location.levels);
    }
}
