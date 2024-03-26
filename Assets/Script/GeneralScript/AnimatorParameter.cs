using UnityEngine;

public class AnimatorParameter : ScriptableObject
{
    public static implicit operator string (AnimatorParameter animParam)
    {
        return animParam.name;
    }
}
