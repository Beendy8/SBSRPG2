using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
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
    [SerializeField] InventoryItem[] _reward;
    [ShowInInspector]
    private int _playerProgress;

    public int playerProgress => _playerProgress;
    public Sprite buttonImage => _buttonImage;
    public int ordinalNumber => _ordinalNumber;
    public InventoryItem[] reward => _reward;

    public void SetPlayerProgress(int value)
    {
        _playerProgress = value;
    }
}
