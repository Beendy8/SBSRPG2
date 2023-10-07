using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class ScriptableObjectSaver : SerializedScriptableObject
{
    string path => $"{Application.persistentDataPath}/";
    [SerializeField] List<ISaveable> saveables;

    private void OnEnable()
    {
        foreach (var saveable in saveables)
            saveable.onChange += Save;
    }
    private void OnDisable()
    {
        foreach (var saveable in saveables)
            saveable.onChange -= Save;
    }
    public string GetFileName(ISaveable saveables)
    {
        return $"{path}/{saveables.GetType()}/{saveables.name}.dat";
    }
    public void Save(ISaveable saveable)
    {
        CreateDirectory($"{saveable.GetType()}");

        string serializedData = JsonUtility.ToJson(saveable);

        using (FileStream stream = new(GetFileName(saveable), FileMode.Create))
        {
            BinaryFormatter formatter = new();
            formatter.Serialize(stream, serializedData);
        }
    }
    void Load(ISaveable saveable)
    {
        if (!File.Exists(GetFileName(saveable)))
            return;
        
        using (FileStream stream = new(GetFileName(saveable), FileMode.Open))
        {
            BinaryFormatter formatter = new();
            string deserializeData = (string)formatter.Deserialize(stream);
            JsonUtility.FromJsonOverwrite(deserializeData, saveable);
        }

        if (saveable is ICustomLoadable loadable)
            loadable.Load();
    }

    public void LoadLevels()
    {
        foreach (var saveable in saveables)
            Load(saveable);
    }

    public void CreateDirectory(string name)
    {
        string fullPath = $"{path}/{name}";

        if (!Directory.Exists(fullPath))
        {
            Directory.CreateDirectory(fullPath);
        }

    }
}
