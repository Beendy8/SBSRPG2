using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDataLoader : MonoBehaviour, IInitializable
{
    [SerializeField] CurrentLevelData _data;
    [SerializeField] CharacterList _enemies;

    public void Initialize()
    {
        LoadLevel();
    }

    public void LoadLevel()
    {
        _enemies.Clear();
        _enemies.AddRange(_data.level.enemies);
    }
}
