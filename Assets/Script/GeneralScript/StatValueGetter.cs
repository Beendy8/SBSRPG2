using UnityEngine;

public class StatValueGetter : MonoBehaviour
{
    [SerializeField] CharacterView _characterView;

    public void GetStatValue(CharacterStat stat)
    {
        _characterView.GetStatValue(stat);
    }
}
