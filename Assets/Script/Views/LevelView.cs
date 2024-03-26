using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LevelView : MonoBehaviour, IView<Level>
{
    [SerializeField] Image _buttonImage;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] GameObject[] _stars;
    Level _level;
    [SerializeField] UnityEvent<Level> _onClick;

    public void InvokeOnClick()
    {
        _onClick.Invoke(_level);
    }
    public void ViewData(Level data)
    {
        _level = data;
        _buttonImage.sprite = _level.buttonImage;
        _text.text = _level.ordinalNumber.ToString();

        for (int i = 0; i < _stars.Length; i++)
            _stars[i].SetActive(_level.playerProgress > i);
    }

    internal void SetActive(bool value)
    {
        gameObject.SetActive(value);
    }
}
