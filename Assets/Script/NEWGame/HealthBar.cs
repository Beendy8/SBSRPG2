using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour, IInitializable
{
    [SerializeField] private Image image;
    [SerializeField] private float maxHP;
    [SerializeField] private float currentHP;
    [SerializeField] private CharacterList characters;
    [SerializeField] private CharacterControllerList attackers;
    private List<CharacterController> subscribes = new();

    public void CountHP()
    {
        foreach (var character in characters)
            maxHP += character.HP;

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
        image.fillAmount = currentHP/maxHP;
        currentHP -= damage;
    }

    public void DebugHP()
    {

    }

    public void OnDestroy()
    {
        foreach (var sub in subscribes)
            if (sub)
                sub.onHit -= ApplyDamage;
    }
}
