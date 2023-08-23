using System;
using UnityEngine;

public class ProgressRecorder : MonoBehaviour
{
    [SerializeField] HealthBar _health;
    [SerializeField] CurrentLevelData _levelData;
    [SerializeField] PlayerProgressSettings _progressSettings;
    [SerializeField] SavedProgress _savedProgress;
    public void RecordProgress()
    {
       var progress = CalculateProgress();
        _savedProgress.Save(_levelData.level, progress);
    }

    public int CalculateProgress()
    {
        var progressThresholds = _progressSettings.thresholds;

        for (int i = 0; i < progressThresholds.Length; i++)
            if (_health.normalizedHealth <= progressThresholds[i])
                return i + 1;

        throw new ArgumentException($"ќшибка при калькул€ции прогресса, жизни игроков{_health.normalizedHealth} длина массива {progressThresholds.Length}");
    }
}
