using System;
using UnityEngine;

public class ProgressRecorder : MonoBehaviour
{
    [SerializeField] HealthBar _health;
    [SerializeField] LevelStorage _level;
    [SerializeField] PlayerProgressSettings _progressSettings;
    [SerializeField] SavedProgress _savedProgress;
    public void RecordProgress()
    {
        var progress = CalculateProgress();

        if (_level.data.playerProgress < progress)
            _savedProgress.Save(_level.data, progress);
    }

    public int CalculateProgress()
    {
        var progressThresholds = _progressSettings.thresholds;

        for (int i = 0; i < progressThresholds.Length; i++)
            if (_health.normalizedHealth <= progressThresholds[i])
                return i + 1;

        throw new ArgumentException($"������ ��� ����������� ���������, ����� �������{_health.normalizedHealth} ����� ������� {progressThresholds.Length}");
    }
}
