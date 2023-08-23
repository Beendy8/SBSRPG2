using Sirenix.OdinInspector;
using System;
using UnityEngine;

public class TimeController : MonoBehaviour 
{
#if UNITY_EDITOR
    [OnValueChanged(nameof(Start))]
    [MinValue(0)]
    [SerializeField] float debugTime = 1;
    private void Start()
    {
        Time.timeScale = debugTime;
    }
#endif
    public void SetActive(bool value) => Time.timeScale = value ? 1 : 0;
}

