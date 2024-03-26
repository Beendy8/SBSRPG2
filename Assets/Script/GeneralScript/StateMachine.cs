using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] List<GameObject> _states;
    [SerializeField] GameObject _lastState;

    public void SetState(GameObject state)
    {
        _lastState.SetActive(false);
        state.SetActive(true);
        _lastState = state;
    }
}
