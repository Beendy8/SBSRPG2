using UnityEngine;

public class LevelDataLoader : MonoBehaviour, IInitializable
{
    [SerializeField] LevelStorage _level;
    [SerializeField] CharacterList _enemies;

    public void Initialize()
    {
        LoadLevel();
    }

    public void LoadLevel()
    {
        Level level = _level;
        _enemies.Clear();
        _enemies.AddRange(level.enemies);
    }
}
