using System.Collections.Generic;
using UnityEngine;

public class AnimatorsParameterSetter : MonoBehaviour, IInitializable
{
    private Animator[] animators;

    public void SetBoolTrue(string name)
    {
        Set(name, true);
    }
    public void SetBoolFalse(string name)
    {
        Set(name, false);
    }

    public void Set(string name, bool value)
    {
        for(int i = 0; i < animators.Length; i++)
            animators[i].SetBool(name, value);
    }
    public void Initialize()
    {
        animators = GetComponentsInChildren<Animator>();
    }
}
