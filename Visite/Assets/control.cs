﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class control : MonoBehaviour
{
    
    public GameObject objectToDisable;
    public static bool disabled = false;


    Dropdown dp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void MadleIputData(int Val)
    {
        if (Val == 0)
        {
            objectToDisable.SetActive(false);
        }

    }
}
