using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class uudelleenSynny : MonoBehaviour
{
    float fallZone = -10f;
    public Transform playerSpawnPoint = null;
    
    int kuolemaLaskuri = 0;

    void Update()
    {
        if (transform.position.y < fallZone)
        {
            transform.position = playerSpawnPoint.position;
            kuolemaLaskuri++;
            deathTextScript.deathAmount += 1;
        }

        if (kuolemaLaskuri >= 3)
        {
            SceneManager.LoadScene(2);
        }
    }
}