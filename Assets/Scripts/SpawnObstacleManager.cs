using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnObstacleManager : MonoBehaviour
{
    [SerializeField]
    GameObject spawningPrefab;

    [SerializeField]
    float spawnSecs = 10f;

    [SerializeField]
    float DestroySecs = 4f;


    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(spawnSecs);


        }
    }

    void SpawnObstacle()
    {
        GameObject newObstacle = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
        Destroy(newObstacle, DestroySecs);
    }



}
