using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroIcon : MonoBehaviour, IView<Character>
{
    [SerializeField] Image _image;
    [SerializeField] TextMeshProUGUI _text;
    [HideInInspector]
    [SerializeField] Character _character;

    public void ViewData(Character data)
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
