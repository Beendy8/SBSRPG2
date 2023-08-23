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
        Character character = data;
        _image.sprite = character.icon;
        _text.text = character.name;
        _character = character;
    }
    public void AddCharacterToList(CharacterList characterList)
    {
        if (!characterList.Contains(_character))
            characterList.Add(_character);
    }
}
