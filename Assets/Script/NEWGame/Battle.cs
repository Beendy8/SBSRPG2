using UnityEngine;
using UnityEngine.Events;

public class Battle : MonoBehaviour
{
    [SerializeField] private UnityEvent onStartBattle;
    public void StartBattle()
    {
        onStartBattle.Invoke();
    }
}
