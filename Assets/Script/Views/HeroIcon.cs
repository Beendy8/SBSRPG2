using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroIcon : MonoBehaviour, IView<CharacterData>
{
    [SerializeField] Image _image;
    [SerializeField] TextMeshProUGUI _text;
    [HideInInspector]
    [SerializeField] CharacterData _character;

    public void ViewData(CharacterData data)
    {
        _character = data;
        _image.sprite = _character.headIcon;
        _text.text = _character.name;
    }
    public void AddCharacterToList(CharacterList characterList)
    {
        if (!characterList.Contains(_character))
            characterList.Add(_character);
    }
}
