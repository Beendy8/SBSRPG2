using UnityEngine;
using UnityEngine.UI;

public class CharacterInventoryView : MonoBehaviour, IView<Character>
{
    Character _character;
    [SerializeField] Image _bodyIcon;
    public void ViewData(Character data)
    {
        _character = data;
        _bodyIcon.sprite = _character.bodyIcon;
    }
}
