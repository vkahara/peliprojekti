using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int juoksija = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        juoksija = juoksija + 1;
        if (juoksija > 50)
        {

            this.transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
            juoksija = 0;
        }

    }




}


