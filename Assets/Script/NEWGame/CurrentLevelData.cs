using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentLevelData : ScriptableObject
{
    Level _level;
    public Level level => _level;
    Location _location;
    public Location location => _location;
    public void LoadLevelData(Level level, Location location)
    {
        _level = level;
        _location = location;
    }
}
