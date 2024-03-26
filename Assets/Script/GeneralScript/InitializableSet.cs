using Sirenix.OdinInspector;
using Sirenix.Serialization;
using Sirenix.Utilities;
using System;
using System.Linq;
using UnityEngine.UI;

public class InitializableSet : SerializedMonoBehaviour, IInitializable
{
    [NonSerialized, OdinSerialize] IInitializable[] _initializables;
    public void Initialize()
    {
        _initializables.ForEach(initializable => initializable.Initialize());
    }

    [Button]
    public void FillInitializables()
    {
        _initializables = GetComponentsInChildren<IInitializable>(true).Where(initializable => initializable != this).ToArray();
    }
}
