using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject greenPrefab;

    [SerializeField]
    private float greenInterval = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(greenInterval, greenPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(-21.0f, -1.70f, -4.60f), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}