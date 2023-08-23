using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Location : ScriptableObject
{
    [SerializeField] Sprite _background;
    public Sprite background => _background;

    [SerializeField] List<Level> _levels;
    public IReadOnlyList<Level> levels => _levels;
}
