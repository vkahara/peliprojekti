﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    // Start is called before the first frame update

    Text sydanCounterText;

    public static int coinAmount;
    
    void Start()
    {
        sydanCounterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        sydanCounterText.text = coinAmount.ToString();
        
    }
}
