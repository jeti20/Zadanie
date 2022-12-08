using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public bool spawned = false;
    void Update()
    {
        if (spawned == false)
        {
            spawned = true;
            StartCoroutine(GenerateNitro()); 
        }
    }
    IEnumerator GenerateNitro()
    {

        Instantiate(enemy, new Vector3(Random.Range(-8.4f, 4.5f), 0, Random.Range(-4.5f, 4.5f)), Quaternion.Euler(0, 0, 180));
        yield return new WaitForSeconds(2);
        spawned = false;
    }
}
