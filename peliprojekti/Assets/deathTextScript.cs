using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathTextScript: MonoBehaviour
{
    // Start is called before the first frame update

    Text deathCounterText;

    public static int deathAmount;

    void Start()
    {
        deathCounterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        deathCounterText.text = deathAmount.ToString();

    }
}