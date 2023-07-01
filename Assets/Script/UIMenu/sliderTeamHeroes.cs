using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class sliderTeamHeroes : MonoBehaviour
{
    [SerializeField] private Slider hpTeam;
    [SerializeField] private float maxHPTeam;
    [SerializeField] private SelectHeroes selectHero;
    [SerializeField] private Heroes team;

    public float currentHPTeam;

    private void Awake()
    {
        //selectHero = GameObject.FindGameObjectWithTag("HeroSelector").GetComponent<SelectHeroes>();
    }

    private void Start()
    {
        //maxHPTeam = selectHero.cc.heros[0].maxHP + selectHero.cc.heros[1].maxHP;
        //currentHPTeam = maxHPTeam;
        //hpTeam.maxValue = maxHPTeam;
        //hpTeam.value = currentHPTeam;
    }

    private void Update()
    {
        //hpTeam.value = currentHPTeam;
        
        //if (currentHPTeam <= 0)
        //{
        //    team.currentSpeedHero = 0;
        //    for (int i = 0; i < selectHero.animHeroes.Count; i++)
        //    {
        //        selectHero.animHeroes[i].SetTrigger("die");
        //    }
        //}
    }

}
