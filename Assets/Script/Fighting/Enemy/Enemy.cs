using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speedEnemy;
    [SerializeField] private Slider sliderEnemy;
    [SerializeField] private float maxHPEnemy;
    [SerializeField] private float currentHPEnemy;
    [SerializeField] private Heroes hero;
    [SerializeField] private Animator animEnemy;
    public int damageEnemy;
    private Rigidbody2D rigidbody2D;
    private IEnumerator corLastEnemy;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animEnemy = GetComponent<Animator>();
        //sliderEnemy = GameObject.FindGameObjectWithTag("SliderEnemy").GetComponent<Slider>();
        hero = GameObject.FindGameObjectWithTag("Team").GetComponent<Heroes>();
    }
    private void Start()
    {
        currentHPEnemy = maxHPEnemy;
        sliderEnemy.maxValue = maxHPEnemy;
        sliderEnemy.value = currentHPEnemy;
    }
    private void Update()
    {
        Move();

        sliderEnemy.value = currentHPEnemy;

        if (currentHPEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Team"))
        {
            speedEnemy = 0;
            animEnemy.SetTrigger("attack_skeleton");
            corLastEnemy = DamageHero();
            StartCoroutine(corLastEnemy);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Team"))
        {
            StopCoroutine(corLastEnemy);
        }
    }

    private void Move()
    {
        transform.Translate(Vector3.left * speedEnemy * Time.deltaTime);
    }

    IEnumerator DamageHero()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            currentHPEnemy -= hero.damageHero;
        }
    }
}
