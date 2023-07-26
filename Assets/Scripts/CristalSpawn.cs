using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalSpawn : MonoBehaviour
{
    public GameObject cristal;
    public float timeSpawn;
    private float rand;
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(timeSpawn);
            rand = Random.Range(-1f, 3f);
            var newcristal = Instantiate(cristal, new Vector3(10,rand, 0), Quaternion.identity);
            Destroy(newcristal, 10);
  
        }
    }

}
