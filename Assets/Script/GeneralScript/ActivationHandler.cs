using UltEvents;
using UnityEngine;

public class ActivationHandler : MonoBehaviour
{
    [SerializeField] UltEvent<bool> _onActivation;

    private void OnEnable()
    {
        _onActivation.Invoke(true);
    }
    private void OnDisable()
    {
        _onActivation.Invoke(false);
    }
}
