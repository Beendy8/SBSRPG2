using UnityEngine;

public class PlayerProgressSettings : ScriptableObject
{
    [SerializeField] float _2StarsThreshold;
    [SerializeField] float _3StarsThreshold;

    public float[] thresholds => new float[] { _2StarsThreshold, _3StarsThreshold, 1};
}
