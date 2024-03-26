using UnityEngine;

public class Spawner : MonoBehaviour, IInitializable
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private CharacterList characters;
    [SerializeField] CharacterViewList spawnedCharacters;
    [SerializeField] CharacterLoader _loader;

    public void Spawn()
    {
        var views = _loader.views;

        for (int i = 0; i < views.Count; i++)
        {
            views[i].transform.position = spawnPoints[i].position;
            spawnedCharacters.Add(views[i].GetComponent<CharacterView>());
        }
    }

    public void Initialize()
    {
        _loader.LoadData(characters);
        spawnedCharacters.Clear();
        Spawn();
    }
}
