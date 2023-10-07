using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatEntryView : MonoBehaviour, IView<KeyValuePair<CharacterStat, float>>
{
    [SerializeField] TextMeshProUGUI _value;
    [SerializeField] Image _icon;
    public void ViewData(KeyValuePair<CharacterStat, float> data)
    {
        _value.text = $"{data.Value}";
        _icon.sprite = data.Key.icon;
    }
}
