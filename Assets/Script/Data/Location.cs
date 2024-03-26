using System.Collections.Generic;
using UnityEngine;

public class Location : ScriptableObject
{
    [SerializeField] Sprite _background;
    public Sprite background => _background;

    [SerializeField] List<Level> _levels;
    public List<Level> levels => _levels;
}
