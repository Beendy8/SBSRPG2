using UnityEngine;

public class LevelRewardClaimer : MonoBehaviour
{
    [SerializeField] InventoryItemList _inventory;

    public void ClaimReward(Level level)
    {
        if (level.playerProgress > 0)
            return;

        _inventory.AddRange(level.reward);
    }
}
