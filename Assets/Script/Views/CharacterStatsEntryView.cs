using System.Collections.Generic;
using System.Linq;
using UltEvents;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsEntryView : MonoBehaviour, IView<CharacterData>
{
    [SerializeField] Image icon;
    [SerializeField] UltEvent <List<KeyValuePair<CharacterStat, float>>> _onView;
    [HideInInspector]
    [SerializeField] CharacterData _character;
    public CharacterData character => _character;
    public void ViewData(CharacterData data)
    {
        _character = data;
        icon.sprite = _character.headIcon;
        _onView.Invoke(_character.stats.ToList());
    }

}
