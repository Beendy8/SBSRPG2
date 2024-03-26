using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public static Wave instance;
    [SerializeField] private TextMeshProUGUI wave;
    [SerializeField] private GameObject startWave;
    [SerializeField] private Heroes hero;
    [SerializeField] private GameObject panelWin;
    [SerializeField] private SpawnEnemy se;
    //[SerializeField] private SkillesOfHeroes skill;
    public int countWave;
    public int allWave;

    private void Awake()
    {
        instance = this;

        hero = GameObject.FindGameObjectWithTag("Team").GetComponent<Heroes>();
        //skill = GameObject.FindGameObjectWithTag("Skill").GetComponent<SkillesOfHeroes>();
        
        //skill.wave = this;

    }
    private void Start()
    {
        countWave = 1;
        se.SpawnEnemys(countWave);
    }
    void Update()
    {
        wave.text = countWave.ToString() + "/" + allWave.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Team"))
        {
            hero.transform.position = startWave.transform.position;
            countWave++;

            se.SpawnEnemys(countWave);

            if (countWave > allWave)
            {
                panelWin.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
