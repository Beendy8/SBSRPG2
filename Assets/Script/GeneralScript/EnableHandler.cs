using UltEvents;
using UnityEngine;

public class EnableHandler : MonoBehaviour
{
    [SerializeField] UltEvent _onEnable;

    private void OnEnable()
    {
        _onEnable.Invoke();
    }
}
