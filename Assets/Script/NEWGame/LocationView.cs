using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationView : MonoBehaviour, IView<Location>, IDataLoader<Level>
{
    [SerializeField] Image background;
    [SerializeField] LevelView levelViewPrefab;
    [SerializeField] Transform levelsParent;
    [SerializeField] CurrentLevelData currentLevelData;
    List<LevelView> levelViews = new();
    Location _location;

    public void ViewData(Location data)
    {
        _location = data;
        background.sprite = _location.background;

        DisableViews();
        CreateNeededViews();
        ReloadViews();
    }

    void DisableViews()
    {
        foreach (var level in levelViews)
            level.SetActive(false);
    }

    void CreateNeededViews()
    {
        int NeededViews = _location.levels.Count - levelViews.Count;

        for (int i = 0; i < NeededViews; i++)
        {
            LevelView newLevelView = Instantiate(levelViewPrefab, levelsParent);
            newLevelView.onClick += SaveCurrentLevelData;
            levelViews.Add(newLevelView);
        }
            
    }
    private void SaveCurrentLevelData(Level level)
    {
        currentLevelData.LoadLevelData(level, _location);
    }

    void ReloadViews()
    {
        for (int i = 0; i < _location.levels.Count; i++)
        {
            if (!_location.levels[i])
                continue;

            levelViews[i].SetActive(true);
            (this as IDataLoader<Level>).LoadData(_location.levels[i], levelViews[i]);
        }
    }
    private void OnDestroy()
    {
        foreach (var levelView in levelViews)
            levelView.onClick -= SaveCurrentLevelData;
    }
}
