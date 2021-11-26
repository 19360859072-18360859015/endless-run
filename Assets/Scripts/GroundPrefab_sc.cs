using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPrefab_sc : MonoBehaviour
{
    Ground_sc groundSpawner;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Ground_sc>(); //Ground tipiyle eslesen ilk nesneyi dondurur.
        SpawnObstacle();
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 1); //olusturulan ground' u yok eder
    }

    public void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

    public void SpawnCoin()
    {
        int coinSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(coinSpawnIndex).transform;
        Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
