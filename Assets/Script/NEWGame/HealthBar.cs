using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour, IInitializable
{
    [SerializeField] private Image image;
    [SerializeField] private float maxHP;
    [SerializeField] private float currentHP;
    [SerializeField] CharacterStat _hpStat;
    public float normalizedHealth => currentHP / maxHP;
    [SerializeField] private CharacterList characters;
    [SerializeField] private CharacterControllerList attackers;
    private List<CharacterController> subscribes = new();
    [SerializeField] private UnityEvent onDie;

    public void CountHP()
    {
        foreach (var character in characters)
        {
            maxHP += character.GetStatValue(_hpStat);
        }
        currentHP = maxHP;
    }

    public void Initialize()
    {
        CountHP();
        HandleAttackers();
    }

    private void HandleAttackers()
    {
        foreach (var attacker in attackers)
        {
            attacker.onHit += ApplyDamage;
            subscribes.Add(attacker);
        }
    }

    public void ApplyDamage(float damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
            onDie.Invoke();

        image.fillAmount = currentHP / maxHP;
    }

    public void OnDestroy()
    {
        foreach (var sub in subscribes)
            if (sub)
                sub.onHit -= ApplyDamage;
    }
}
