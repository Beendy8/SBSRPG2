using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public class SavedProgress : ScriptableObject
{
    [SerializeField] SerializedDict<Level, int> _progress = new();
    const string fileName = "progress.Data";
    string path => $"{Application.persistentDataPath}/{fileName}";
    [SerializeField] int x;
    public void Save(Level level, int playerProgress)
    {
        SetProgressData(level, playerProgress);
        level.SetPlayerProgress(playerProgress);
        string serializedData = JsonUtility.ToJson(this);
        FileStream stream = new(path, FileMode.Create);
        BinaryFormatter formatter = new();
        formatter.Serialize(stream, serializedData);
        stream.Close();
    }
    public void SetProgressData(Level level, int playerProgress)
    {
        _progress[level] = playerProgress;
    }
    public void Load()
    {
        if (!File.Exists(path))
            return;

        FileStream stream = new(path, FileMode.Open);
        BinaryFormatter formatter = new();
        string deserializeData = (string)formatter.Deserialize(stream);
        JsonUtility.FromJsonOverwrite(deserializeData, this);
        stream.Close();

        foreach (var entry in _progress)
        {
            entry.Key.SetPlayerProgress(entry.Value);
        }
    }

}
