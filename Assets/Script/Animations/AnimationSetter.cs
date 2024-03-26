using Sirenix.Utilities;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnimationSetter : MonoBehaviour, IInitializable
{
    [SerializeField] private CharacterViewList _characterViews;
    [SerializeField] Animator[] _animators;

    public void Initialize()
    {
        _animators = ((List<CharacterView>)_characterViews).Select(view => view.animator).ToArray();
    }
    public void SetBool(AnimatorParameter animParam, bool value)
    {
        _animators.ForEach(animator => animator.SetBool(animParam, value));
    }
    public void SetTrigger(AnimatorParameter animParam)
    {
        _animators.ForEach(animator => animator.SetTrigger(animParam));
    }
}
