using UnityEngine;
using UnityEngine.UI;

public class CharacterInventoryView : MonoBehaviour, IView<CharacterData>
{
    CharacterData _character;
    [SerializeField] Image _bodyIcon;
    public void ViewData(CharacterData data)
    {
        _character = data;
        _bodyIcon.sprite = _character.bodyIcon;
    }
}
