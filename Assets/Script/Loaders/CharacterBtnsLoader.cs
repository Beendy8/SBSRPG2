using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterBtnsLoader : MonoBehaviour, IDataLoader<CharacterData>
{
    [SerializeField] CharacterList _characterList;
    [SerializeField] CharacterBtn[] _characterBtns;
    const int maxCharacterCount = 5;

    private void Start()
    {
        Load(null);
    }
    private void OnEnable()
    {
        _characterList.onChange += Load;
    }

    private void OnDisable()
    {
        _characterList.onChange -= Load;
    }

    [Button]

    private void Load(ISaveable saveable)
    {
        Assert.IsTrue(_characterBtns.Length == maxCharacterCount, $"characterBtns count {_characterBtns.Length}");
        Assert.IsTrue(_characterList.Count <= maxCharacterCount, $"characterList count {_characterList.Count}");

        for (int i = 0; i < _characterList.Count; i++)
        {
            (this as IDataLoader<CharacterData>).LoadData(_characterList[i], _characterBtns[i]);
        }
    }
}
