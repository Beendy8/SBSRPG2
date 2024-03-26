using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private float maxHP;
    [SerializeField] private float currentHP;
    public float normalizedHealth => currentHP / maxHP;
    [SerializeField] private UnityEvent onDie;

    public void ApplyDamage(float damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
            onDie.Invoke();

        image.fillAmount = currentHP / maxHP;
    }
    public void AddMaxHP(float value)
    {
        maxHP += value;
        currentHP += value;
    }
}
