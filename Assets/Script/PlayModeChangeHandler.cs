using UltEvents;
using UnityEditor;
using UnityEngine;

public class PlayModeChangeHandler : ScriptableObject
{
    [SerializeField] bool _isActive;
    [SerializeField] UltEvent _onPlayModeChange;
    [SerializeField] PlayModeStateChange _targetState;
    

    private void OnEnable()
    {
        EditorApplication.playModeStateChanged += Handle;
    }
    private void OnDisable()
    {
        EditorApplication.playModeStateChanged -= Handle;
    }
    private void Handle(PlayModeStateChange state)
    {
        if (!_isActive)
            return;

        if (state == _targetState)
            _onPlayModeChange.Invoke();
    }
}
