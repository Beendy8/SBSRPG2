using UnityEngine;
using UnityEngine.UI;

public class CharacterStat : ScriptableObject
{
    [SerializeField] float _defaultValue;
    [SerializeField] Sprite _icon;
    public Sprite icon => _icon;
    public float defaultValue => _defaultValue;
}
