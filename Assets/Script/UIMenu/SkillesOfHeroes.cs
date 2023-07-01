using UnityEngine;
using UnityEngine.UI;

public class SkillesOfHeroes : MonoBehaviour
{
    [SerializeField] private GameObject[] skilles;
    [SerializeField] private Transform posSkill;
    [SerializeField] private Button activeSkill;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Skill");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        transform.position = posSkill.transform.position;
        if (Wave.instance.countWave == 2)
        {
            GameObject skill = Instantiate(skilles[0], transform.position, Quaternion.identity);
            activeSkill.interactable = true;
        }
    }

    private void Update()
    {

    }
    public void UseSkill()
    {

    }
}
