using UnityEngine;

public class InventoryItem : ScriptableObject
{
    [SerializeField] Sprite _icon;
    [SerializeField] SerializedDict<string, float> _stats;
}
