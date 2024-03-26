using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : ScriptableObject
{
    public void LoadScene(SceneAsset scene)
    {
        SceneManager.LoadScene(scene.name);
    }
}
