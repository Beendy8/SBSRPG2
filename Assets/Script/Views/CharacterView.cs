using UltEvents;
using UnityEngine;

public class CharacterView : MonoBehaviour, IView<CharacterData>
{
    private CharacterData _character;
    [SerializeField] Animator _animator;
    [SerializeField] UltEvent _onViewData;
    public Animator animator => _animator;

    public void ViewData(CharacterData data)
    {
        _character = data;
        _animator.runtimeAnimatorController = _character.animator;
        _animator.Update(0f);
        _onViewData.Invoke();
    }
    public float GetStatValue(CharacterStat stat)
    {
        return _character.GetStatValue(stat);
    }
}
