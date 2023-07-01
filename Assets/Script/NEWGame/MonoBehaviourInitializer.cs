using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourInitializer : SerializedMonoBehaviour
{
    [SerializeField] private MonoBehaviour[] monoBehaviours;
    
    [NonSerialized, OdinSerialize] private List<IInitializable> initializable = new();
    private void Start()
    {
        foreach (var behaviour in monoBehaviours)
            if (behaviour is IInitializable initializable)
                initializable.Initialize();
    }
}
