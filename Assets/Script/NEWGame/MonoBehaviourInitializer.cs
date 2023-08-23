using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourInitializer : SerializedMonoBehaviour
{ 
    
    [NonSerialized, OdinSerialize] private List<IInitializable> initializables = new();
    private void Start()
    {
        foreach (var behaviour in initializables)
            behaviour.Initialize();
    }
}
