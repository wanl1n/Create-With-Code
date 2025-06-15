using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject powerup;

    private int waveCounter = 1;
    private int enemyCount = 0;

    void Start()
    {
    }

    void Update()
    {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;

        if (enemyCount == 0)
        {
            waveCounter++;
            SpawnPowerup();
            SpawnMouseWaves(waveCounter);
        }
    }

    void SpawnPowerup()
    {
        GameObject pu = Instantiate(powerup, GenerateRandomPos(), powerup.transform.rotation);
    }

    void SpawnMouseWaves(int miceCount)
    {
        for (int i = 0; i < miceCount; i++)
        {
            Instantiate(enemy, GenerateRandomPos(), enemy.transform.rotation);
        }
    }

    Vector3 GenerateRandomPos()
    {
        float randX = Random.Range(-19.0f, 19.0f);
        float randZ = Random.Range(-10.0f, 1.0f);
        return new Vector3(randX, 0.267f, randZ);
    }
}
