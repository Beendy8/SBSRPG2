using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsEntry : MonoBehaviour, IView<Character>, IDataLoader<KeyValuePair<CharacterStat, float>>
{
    [SerializeField] Image icon;
    [HideInInspector]
    [SerializeField] Character _character;
    public Character character => _character;
    [SerializeField] CharacterStat[] _stats;
    [SerializeField] StatEntryView _statViewPrefab;
    [SerializeField] Transform _statViewsParent;
    public void ViewData(Character data)
    {
        _character = data;
        icon.sprite = _character.icon;
        LoadStats();
    }
    public void LoadStats()
    {
        foreach (var stat in _stats)
        {
            var statEntryView = Instantiate(_statViewPrefab, _statViewsParent);
            statEntryView.gameObject.SetActive(true);
            var data = new KeyValuePair<CharacterStat, float>(stat, character.stats[stat]);
            (this as IDataLoader<KeyValuePair<CharacterStat, float>>).LoadData(data, statEntryView);
        }
    }
}
