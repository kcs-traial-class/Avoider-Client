using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 1.0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float x = Random.Range(-7f, 7f);
        Vector2 spawnPos = new Vector2(x, 6f); // âÊñ è„ïîÇ©ÇÁèoåª
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
