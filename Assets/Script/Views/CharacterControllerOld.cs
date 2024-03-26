using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterControllerOld : MonoBehaviour, IView<Character>
{
    private Character _character;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Coroutine animationCoroutine;
    private Dictionary<string, CustomAnimation> animations = new();
    public event Action<float> onHit;
    private bool isAttacking;
    [SerializeField] CharacterStat _damageStat;
    [SerializeField] Animator _animator;

    public void ViewData(Character data)
    {
        _character = data;
        animations.Add("run", _character.run);
        animations.Add("attack", _character.attack);
        animations.Add("die", _character.die);
        SetAnimation("run");
        _animator.runtimeAnimatorController = _character.animator;
    }

    public void SetAnimation(string animName)
    {
        isAttacking = animName == "attack";

        if (animationCoroutine != null)
            StopCoroutine(animationCoroutine);
        animationCoroutine = StartCoroutine(AnimationLoop(animations[animName], animName));
    }

    IEnumerator AnimationLoop(CustomAnimation animation, string animName)
    {
        Assert.IsTrue(animation.sprites.Length != 0, $"У {_character.name} не заполнена анимация {animName}");

        while (true)
        {
            for (int i = 0; i < animation.sprites.Length; i++)
            {
                spriteRenderer.sprite = animation.sprites[i];
                yield return new WaitForSeconds(animation.duration / animation.sprites.Length);
            }
            if (isAttacking)
                onHit?.Invoke(_character.GetStatValue(_damageStat));

            if (!animation.loop)
                break;
        }
    }
}
