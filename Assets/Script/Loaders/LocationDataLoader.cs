using UnityEngine;

public class LocationDataLoader : MonoBehaviour, IInitializable
{
    [SerializeField] LocationStorage _location;
    [SerializeField] SpriteRenderer _sceneBackground;

    public void Initialize()
    {
        LoadLocation();
    }

    public void LoadLocation()
    {
        Location location = _location;
        _sceneBackground.sprite = location.background;
    }
}
