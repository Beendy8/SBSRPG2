using UnityEngine;
using UnityEngine.UI;

public class InventoryItemView : MonoBehaviour, IView<InventoryItem>
{
    [SerializeField] InventoryItem _item;
    [SerializeField] Image _icon;
    public void ViewData(InventoryItem data)
    {
        _item = data;
        _icon.sprite = _item.icon;
    }
}
