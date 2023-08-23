using Sirenix.OdinInspector;
using System;
using UnityEngine;

[Serializable]
public class Level : ScriptableObject
{
    [SerializeField] string _name;
    [SerializeField] Character[] _enemies;
    public Character[] enemies => _enemies;
    [SerializeField] int _difficulty;
    [SerializeField] Sprite _buttonImage;
    [SerializeField] int _ordinalNumber;
    [ShowInInspector]
    private int _playerProgress;

    public int playerProgress => _playerProgress;
    public Sprite buttonImage => _buttonImage;
    public int ordinalNumber => _ordinalNumber;

    public void SetPlayerProgress(int value)
    {
        _playerProgress = value;
    }
}
