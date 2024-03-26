using UltEvents;
using UnityEngine;

public class GlobalListChangeHandler : MonoBehaviour
{
    [SerializeField] CharacterList _globalList;
    [SerializeField] UltEvent _onChange;

    private void OnEnable()
    {
        HandleChange(null);
        _globalList.onChange += HandleChange;
    }
    private void OnDisable()
    {
        _globalList.onChange -= HandleChange;
    }

    public void HandleChange(ISaveable  saveable)
    {
        _onChange.Invoke();
    }
}
