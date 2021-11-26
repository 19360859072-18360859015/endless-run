using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_sc : MonoBehaviour
{
    [SerializeField] GameObject groundTile;
    Vector3 SpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, SpawnPoint, Quaternion.identity);
        SpawnPoint = temp.transform.GetChild(1).transform.position; //plane spawnlamak istedigimiz noktaya ground'un birinci child' ini koyduk

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 20; i++)
        {
            SpawnTile();
        }
        
    }
}
