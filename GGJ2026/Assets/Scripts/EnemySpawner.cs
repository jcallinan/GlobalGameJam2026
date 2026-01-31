using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnInterval = 2f;
    public float radius = 15f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 pos = transform.position + Random.insideUnitSphere * radius;
        pos.y = 1.3f;

        GameObject enemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        Instantiate(enemy, pos, Quaternion.identity);
    }
}
