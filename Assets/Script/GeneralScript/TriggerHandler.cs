using UltEvents;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] UltEvent _onTrigger;
    public void Trigger()
    {
        _onTrigger.Invoke();
    }
}
