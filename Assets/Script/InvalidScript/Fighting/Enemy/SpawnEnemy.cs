using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private LevelSpawn[] levelSpawns;
    [SerializeField] private Transform[] pointSpawn;
    [SerializeField] private SelectHeroes selectHeroes;
    [SerializeField] private GameObject[] e;

    public int damageEnemy;

    private void Awake()
    {
        //selectHeroes = GameObject.FindGameObjectWithTag("HeroSelector").GetComponent<SelectHeroes>();
    }
    public void SpawnEnemys(int wave)
    {
        //int indexMission = selectHeroes.missionNumber - 1;

        //if (levelSpawns[indexMission].enemy1[wave - 1])
        //    e[0] = Instantiate(levelSpawns[indexMission].enemy1[wave - 1], pointSpawn[0].position, Quaternion.identity);

        //if (levelSpawns[indexMission].enemy2[wave - 1])
        //    e[1] = Instantiate(levelSpawns[indexMission].enemy2[wave - 1], pointSpawn[1].position, Quaternion.identity);

        //if (levelSpawns[indexMission].enemy3[wave - 1])
        //    e[2] = Instantiate(levelSpawns[indexMission].enemy3[wave - 1], pointSpawn[2].position, Quaternion.identity);

        //if (levelSpawns[indexMission].enemy4[wave - 1])
        //    e[3] = Instantiate(levelSpawns[indexMission].enemy4[wave - 1], pointSpawn[3].position, Quaternion.identity);

        //if (levelSpawns[indexMission].enemy5[wave - 1])
        //    e[4] = Instantiate(levelSpawns[indexMission].enemy5[wave - 1], pointSpawn[4].position, Quaternion.identity);

        //for (int i = 0; i < e.Length; i++)
        //{
        //    if (e[i])
        //    {
        //        damageEnemy += e[i].GetComponent<Enemy>().damageEnemy;
        //    }

        //}
    }
}

[System.Serializable]
public class LevelSpawn
{
    public GameObject[] enemy1;
    public GameObject[] enemy2;
    public GameObject[] enemy3;
    public GameObject[] enemy4;
    public GameObject[] enemy5;
}
