using UnityEngine;

public class LevelRewardClaimer : MonoBehaviour
{
    [SerializeField] InventoryItemList _inventory;

    public void ClaimReward(Level level)
    {
        _inventory.AddRange(level.reward);
    }
}
