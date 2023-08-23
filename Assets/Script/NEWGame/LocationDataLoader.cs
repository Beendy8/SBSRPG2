using UnityEngine;

public class LocationDataLoader : MonoBehaviour, IInitializable
{
    [SerializeField] CurrentLevelData _data;
    [SerializeField] SpriteRenderer _sceneBackground;

    public void Initialize()
    {
        LoadLocation();
    }

    public void LoadLocation()
    {
        _sceneBackground.sprite = _data.location.background;
    }
}
