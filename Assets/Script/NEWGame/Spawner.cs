using UnityEngine;

public class Spawner : MonoBehaviour, IInitializable
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Transform spawnParent;
    [SerializeField] private CharacterController prefabSource;
    [SerializeField] private CharacterList characters;
    [SerializeField] CharacterControllerList spawnedCharacters;

    public void Spawn()
    {
        for (int i = 0; i < characters.Count; i++)
        {
            CharacterController spawnedObject = Instantiate(prefabSource, spawnPoints[i].position, spawnParent.rotation, spawnParent);
            spawnedObject.LoadData(characters[i]);
            spawnedCharacters.Add(spawnedObject);
        }
    }

    public void Initialize()
    {
        spawnedCharacters.Clear();
        Spawn();
    }
}