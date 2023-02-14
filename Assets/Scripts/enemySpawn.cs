using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject regEnemyPrefab;
    public GameObject laserEnemyPrefab;
    public int waveAmount = 4;
    public int timeBetweenWaves = 2;
    public int regEnemiesPerWave = 4;
    public int laserEnemiesPerWave = 2;
    public int waveNumber = 0;

    private void Start()
    {
        Debug.Log("Enemy Wave Spawner Started");
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {

        while (waveNumber < waveAmount)
        {
            for (int i = 0; i < regEnemiesPerWave + laserEnemiesPerWave; i++)
            {
                Debug.Log("StartedWave");
                Vector3 spawnPoint = new Vector3(Random.Range(-13f, 13f), Random.Range(-3.5f, -7f), 0);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(regEnemyPrefab, spawnPoint, spawnRotation);
                Instantiate(laserEnemyPrefab, spawnPoint, spawnRotation);
                yield return new WaitForSeconds(1f);
            }
            waveNumber++;
            Debug.Log("New Wave");
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
}
