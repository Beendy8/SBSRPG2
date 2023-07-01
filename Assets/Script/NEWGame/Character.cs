using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

public class Character : ScriptableObject
{
    [FoldoutGroup("Stats")]
    [SerializeField] private float _HP;
    [FoldoutGroup("Stats")]
    [SerializeField] private float _Damage;
    [FoldoutGroup("Stats")]
    [SerializeField] private float _attackSpeed = 1;

    [FoldoutGroup("Animation")]
    public CustomAnimation run;
    [FoldoutGroup("Animation")]
    public CustomAnimation attack;
    [FoldoutGroup("Animation")]
    public CustomAnimation die;

    public float HP => _HP;
    public float Damage => _Damage;

    private void OnEnable()
    {
        run.SetLoop(true);
        attack.SetLoop(true);
        die.SetLoop(false);
    }
    public void SetAttackDuration()
    {
        attack.SetDuration(1 / _attackSpeed);
    }
}
