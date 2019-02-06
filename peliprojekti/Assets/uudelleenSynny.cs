using UnityEngine;
using System.Collections;

public class uudelleenSynny : MonoBehaviour
{
    float fallZone = -10f;
    public Transform playerSpawnPoint = null;
    void Update()
    {
        if (transform.position.y < fallZone)
        {
            transform.position = playerSpawnPoint.position;
        }
    }
}