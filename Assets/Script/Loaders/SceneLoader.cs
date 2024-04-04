using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : ScriptableObject
{
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
