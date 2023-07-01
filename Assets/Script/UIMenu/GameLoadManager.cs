using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{
    public int maxLvl;
    public string starInLvl;
}
public class GameLoadManager : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    public int[] starsCount;
    [SerializeField] private GameObject[] starsIcon;
    [SerializeField] private Button[] levels;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GLM");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        OpenMap();
    }
    public void OpenMap()
    {
        for (int i = 0; i < starsCount.Length; i++)
        {
            for (int k = 0; k < 3; k++)
            {
                if (starsCount[i] >= k + 1)
                {
                    starsIcon[k + 3 * i].SetActive(true);
                }
            }

        }

        for (int i = 0; i < levels.Length; i++)
        {
            if (i < playerData.maxLvl)
            {
                levels[i].interactable = true;
            }
        }
    }
}
