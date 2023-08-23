using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Battle : MonoBehaviour
{
    [FoldoutGroup("StartBattle")]
    [SerializeField] private UnityEvent onStartBattle;
    [FoldoutGroup("EndBattleForHeroes")]
    [SerializeField] private UnityEvent onWinBattle;
    [FoldoutGroup("EndBattleForEmemies")]
    [SerializeField] private UnityEvent onLoseBattle;
    
    public void StartBattle()
    {
        onStartBattle.Invoke();
    }
    public void WinBattle()
    {
        onWinBattle.Invoke();
    }
    public void LoseBattle()
    {
        onLoseBattle.Invoke();
    }
}
