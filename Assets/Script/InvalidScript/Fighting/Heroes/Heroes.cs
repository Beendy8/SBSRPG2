using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heroes : MonoBehaviour
{
    [SerializeField] private float speedHero;
    [SerializeField] private SpawnEnemy spawnerEnemy;
    [SerializeField] private SelectHeroes selectHero;
    [SerializeField] private sliderTeamHeroes sliderHPTeam;
    public float damageHero;

    private IEnumerator corLast;
    private Rigidbody2D rigidbody2D;
    public float currentSpeedHero;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        selectHero = GameObject.FindGameObjectWithTag("HeroSelector").GetComponent<SelectHeroes>();
        


        GameObject[] objs = GameObject.FindGameObjectsWithTag("Team");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    //private void Start()
    //{

    //    currentSpeedHero = speedHero;

    //    for (int i = 0; i < selectHero.heroes.Count; i++)
    //    {
    //        damageHero += selectHero.heroes[i].damage;
    //    }
    //}
    private void Update()
    {
        if (selectHero.goFight == true)
        {
            Move();
        }

        //if (currentHPTeam <= 0)
        //{
        //    for (int i = 0; i < selectHero.animHeroes.Count; i++)
        //    {
        //        selectHero.animHeroes[i].SetTrigger("die");
        //    }

        //    //Destroy(gameObject, 2);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            spawnerEnemy = GameObject.FindGameObjectWithTag("enemyTeam").GetComponent<SpawnEnemy>();

            currentSpeedHero = 0;
            for (int i = 0; i < selectHero.animHeroes.Count; i++)
            {
                selectHero.animHeroes[i].SetBool("attack", true);
            }
            corLast = DamageEnemy();
            StartCoroutine(corLast);

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            for (int i = 0; i < selectHero.animHeroes.Count; i++)
            {
                selectHero.animHeroes[i].SetBool("attack", false);
            }

            StopCoroutine(corLast);
            currentSpeedHero = speedHero;
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            //sliderHPTeam = GameObject.FindGameObjectWithTag("HPTeam").GetComponent<sliderTeamHeroes>();
        }
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Move()
    {
        transform.Translate(Vector3.right * currentSpeedHero * Time.deltaTime);
    }

    IEnumerator DamageEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            sliderHPTeam.currentHPTeam -= spawnerEnemy.damageEnemy;
        }
    }
}
