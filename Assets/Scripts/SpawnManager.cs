using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnEnemyRoutine()
    {
        while(true)
        {
            Instantiate(enemy, new Vector3(Random.Range(-5f, 5f), 0.25f, 5), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }

    }

}
