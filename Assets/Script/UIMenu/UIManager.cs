using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private GameObject panelLose;
    [SerializeField] private Heroes hero;
    [SerializeField] private GameLoadManager GLM;
    public float timerCount;

    private void Update()
    {
        
        timerCount -= Time.deltaTime;
        timer.text = timerCount.ToString("00.00");
        Timer();
    }

    private void Timer()
    {
        if (timerCount <= 0)
        {
            panelLose.SetActive(true);
        }
    }

}
