using Sirenix.OdinInspector;
using UnityEngine;

public class Character : ScriptableObject
{
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
    public Sprite icon => _icon;
    private void OnEnable()
    {
        run.SetLoop(true);
        attack.SetLoop(true);
        die.SetLoop(false);
    }
    //public void SetAttackDuration()
    //{
    //    attack.SetDuration(1 / _attackSpeed);
    //}

    [SerializeField] SerializedDict<CharacterStat, float> _stats;
    public SerializedDict<CharacterStat, float> stats => _stats;

    public float GetStatValue(CharacterStat characterStat)
    {
        return _stats[characterStat];
    }
}
