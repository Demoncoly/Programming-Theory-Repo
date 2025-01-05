using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    private float spawnRangeMin = 5f;
    private float spawnRangeMax = 50f;
    private GameObject spawnCount;
    private int spawnNumber = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void spawnPickups(int pickupsToSpawn)
    {
        for (int i = 0; i < pickupsToSpawn; i++)
        {
            Instantiate(spawnPrefab, GenerateSpawnPosition(), spawnPrefab.transform.rotation);
        }
    }
    void Update()
    {
        spawnCount = GameObject.FindGameObjectWithTag("Spawn");
        if (spawnCount == null)
        {
            spawnNumber++;
            spawnPickups(spawnNumber);
        }

    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(spawnRangeMin, spawnRangeMax);
        float spawnPosZ = Random.Range(spawnRangeMin, spawnRangeMax);
        Vector3 randomPos = new Vector3(spawnPosX, 2.5f, spawnPosZ);
        return randomPos;
    }
}
