using System.Collections.Generic;
using System.Linq;
using UltEvents;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsEntryView : MonoBehaviour, IView<Character>
{
    [SerializeField] Image icon;
    [SerializeField] UltEvent <List<KeyValuePair<CharacterStat, float>>> _onView;
    [HideInInspector]
    [SerializeField] Character _character;
    public Character character => _character;
    public void ViewData(Character data)
    {
        _character = data;
        icon.sprite = _character.headIcon;
        _onView.Invoke(_character.stats.ToList());
    }

}
