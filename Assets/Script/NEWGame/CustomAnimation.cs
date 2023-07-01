using System;
using UnityEngine;
[Serializable]
public class CustomAnimation
{
    private float _duration = 1;
    private bool _loop;
    public Sprite[] sprites;
    public bool loop => _loop;
    public float duration => _duration;
    public void SetLoop(bool value)
    {
        _loop = value;
    }
    public void SetDuration(float value) 
    {
        _duration = value;
    }
}
