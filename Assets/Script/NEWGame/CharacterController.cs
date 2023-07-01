using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController : MonoBehaviour
{
    public Character _data;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Coroutine animationCoroutine;
    private Dictionary<string, CustomAnimation> animations = new();
    public event Action<float> onHit;
    private bool isAttacking;

    public void LoadData(Character data)
    {
        _data = data;
        animations.Add("run", _data.run);
        animations.Add("attack", _data.attack);
        animations.Add("die", _data.die);
        SetAnimation("run");
    }

    public void SetAnimation(string animName)
    {
        isAttacking = animName == "attack";

        if (animationCoroutine != null)
            StopCoroutine(animationCoroutine);
        animationCoroutine = StartCoroutine(AnimationLoop(animations[animName]));
    }

    IEnumerator AnimationLoop(CustomAnimation animation)
    {
        while (true)
        {
            for (int i = 0; i < animation.sprites.Length; i++)
            {
                spriteRenderer.sprite = animation.sprites[i];
                yield return new WaitForSeconds(animation.duration / animation.sprites.Length);
            }

            if (isAttacking)
                onHit?.Invoke(_data.Damage);

            if (!animation.loop)
                break;
        }

    }

}
