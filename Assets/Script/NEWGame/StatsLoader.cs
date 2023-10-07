using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class StatsLoader : OdinEditorWindow
{
    [SerializeField] Character[] _characters;
    [SerializeField] CharacterStat[] _stats;

    [MenuItem("Tools/Character Stats Loader")]
    private static void OpenWindow()
    {
        GetWindow<StatsLoader>().Show();
    }

    [OnInspectorInit]
    public void Initialize()
    {
        _characters = GetAssetsOfType<Character>();
        _stats = GetAssetsOfType<CharacterStat>();
    }

    T[] GetAssetsOfType<T>() where T : Object
    {
        string[] guids = AssetDatabase.FindAssets($"t:{typeof(T).Name}");

        T[] result = new T[guids.Length];

        for (int i = 0; i < guids.Length; i++)
        {
            string path = AssetDatabase.GUIDToAssetPath(guids[i]);

            result[i] = AssetDatabase.LoadAssetAtPath<T>(path);
        }

        return result;
    }

    [Button]
    public void LoadDefaultStats()
    {
        foreach (var character in _characters)
            LoadCharactersDefaultStats(character);
    }
    void LoadCharactersDefaultStats(Character character)
    {
        foreach (var stat in _stats)
        {
            if (!character.stats.ContainsKey(stat))
                character.stats[stat] = stat.defaultValue;
        }
    }
}
