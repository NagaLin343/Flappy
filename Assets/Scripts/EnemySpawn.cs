using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    public float timeSpawn;
    private GameObject en;
    void Start()
    {
         StartCoroutine(Spawner());
    }
        IEnumerator Spawner()
        {
            while (true)
            {
                int random = Random.Range(0, enemy.Length);
                //en =enemy[random];
                yield return new WaitForSeconds(timeSpawn);
                GameObject newEnemy = Instantiate(enemy[random], new Vector3(10, 0, 0), Quaternion.identity);
                Destroy(newEnemy, 10);

            }
        }
    
}
