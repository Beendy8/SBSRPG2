using System;
using UnityEngine;

public class CharacterSelector : ScriptableObject
{
    [SerializeField] CharacterList _characterList;
    int _btnIndex;

    public void SelectCharacter(CharacterStatsEntryView entry)
    {
        if (_characterList.Count <= _btnIndex)
            _characterList.Add(entry.character);
        else
            _characterList.Modify(_btnIndex, entry.character);
    }
    public void SelectButton(int index)
    {
        _btnIndex = index;
    }
}
