using Unity.VisualScripting;
using UnityEngine;

public class DelayedDeactivator : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] CharacterControllerList characterControllers;
    public void StartDelay()
    {
        Invoke(nameof(Deactivate), time);
    }
    
    private void Deactivate()
    {
        foreach (var character in characterControllers)
            character.gameObject.SetActive(false);
    }
}
