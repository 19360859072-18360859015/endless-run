using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_sc : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position; //player ile camera arasindaki mesafeyi korumak icin
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = player.position + offset;
        targetPosition.x = 0; // kameranin saða sola hareket etmemesi icin(ortada kalmasi)
        transform.position = targetPosition;
        
    }
}
