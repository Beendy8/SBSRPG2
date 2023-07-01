using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectHeroes : MonoBehaviour
{
    [SerializeField] private List<int> heroesNumbers = new List<int>();
    public List<Animator> animHeroes = new List<Animator>();
    public CharacterController cc;
    [SerializeField] private Transform[] spawnHeroes;
    [SerializeField] private Transform transformTeam;
    //[SerializeField] private GlobalList chosenHeroes;
    //public List<Hero> heroes = new List<Hero>();
    public int missionNumber = 1;
    public bool goFight = false;
    private const string levelName = "Game";

    void Awake()
    {
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("HeroSelector");

        //if (objs.Length > 1)
        //{
        //    Destroy(this.gameObject);
        //}

        //DontDestroyOnLoad(this.gameObject);
        //chosenHeroes.Clear();
    }

    public void ChooseHero(int heroIndex)
    {
        //    if (heroesNumbers.Count < 5)
        //    {
        //        for (int i = 0; i < heroesNumbers.Count; i++)
        //        {
        //            if (heroesNumbers[i] == heroIndex)
        //            {
        //                return;
        //            }
        //        }

        //        heroesNumbers.Add(heroIndex);

        //        GameObject h = Instantiate(cc.heros[heroIndex].prefabHero, spawnHeroes[heroesNumbers.Count - 1].position, Quaternion.identity, transformTeam);

        //        animHeroes.Add(h.GetComponent<Animator>());



        //chosenHeroes.Add(cc.heros[heroIndex].prefabHero);
        //    }
    }

    public void GoFigth(int MN)
    {
        //goFight = true;

        //for (int i = 0; i < heroesNumbers.Count; i++)
        //{
        //    heroes.Add(cc.heros[heroesNumbers[i]]);
        //}

        //missionNumber = MN;

        SceneManager.LoadScene(levelName);
    }


}
