using System;
using UnityEngine;


public class SavedProgress : ScriptableObject, ICustomLoadable
{
    [SerializeField] SerializedDict<Level, int> _progress = new();

    public event Action<ISaveable> onChange;

    public void Save(Level level, int playerProgress)
    {
        SetProgressData(level, playerProgress);
        level.SetPlayerProgress(playerProgress);
    }
    public void SetProgressData(Level level, int playerProgress)
    {
        _progress[level] = playerProgress;
        onChange?.Invoke(this);
    }
    public void Load()
    {
        foreach (var entry in _progress)
            entry.Key.SetPlayerProgress(entry.Value);
    }

}
