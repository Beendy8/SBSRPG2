using UltEvents;
using UnityEngine;

public class StartHandler : MonoBehaviour
{
    [SerializeField] UltEvent _onStart;
    void Start()
    {
        _onStart.Invoke();
    }
}
