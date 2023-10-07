using UnityEngine;
using UnityEngine.UI;

public class CharacterBtn : MonoBehaviour, IView<Character>
{
    [SerializeField] Image icon;
    Character _character;

    public void ViewData(Character data)
    {
        _character = data;
        icon.sprite = _character.icon;
    }
}
