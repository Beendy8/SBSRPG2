using UnityEngine;
using UnityEngine.UI;

public class CharacterBtn : MonoBehaviour, IView<CharacterData>
{
    [SerializeField] Image icon;
    CharacterData _character;

    public void ViewData(CharacterData data)
    {
        _character = data;
        icon.sprite = _character.headIcon;
    }
}
