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
    [OnValueChanged(nameof(SetAttackDuration))]
    [SerializeField] private float _attackSpeed = 1;

    [FoldoutGroup("Animation")]
    [InfoBox("Не заполнена анимация", InfoMessageType.Error, "@this.run.sprites.Length == 0")]
    public CustomAnimation run;
    [FoldoutGroup("Animation")]
    [InfoBox("Не заполнена анимация", InfoMessageType.Error, "@this.attack.sprites.Length == 0")]
    public CustomAnimation attack;
    [InfoBox("Не заполнена анимация", InfoMessageType.Error, "@this.die.sprites.Length == 0")]
    [FoldoutGroup("Animation")]
    public CustomAnimation die;

    [SerializeField] Sprite _icon;
    public float HP => _HP;
    public Sprite icon => _icon;
    public float Damage => _Damage;

    private void OnEnable()
    {
        run.SetLoop(true);
        attack.SetLoop(true);
        die.SetLoop(false);
    }
    public void SetAttackDuration()
    {
       attack.SetDuration( 1 / _attackSpeed);
    }
}
