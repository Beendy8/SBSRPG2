using UnityEngine;
using UnityEngine.Events;

public class GameLoader : MonoBehaviour
{
    [SerializeField] UnityEvent startActions;

    private void Start()
    {
        startActions.Invoke();
    }
}
