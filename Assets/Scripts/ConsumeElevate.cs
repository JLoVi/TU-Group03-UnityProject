﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConsumeElevate : MonoBehaviour
{
    public GameObject step;

    public int elevationScale;

    public Text crystalAmountDisplay;

    public int crystalAmount;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //create a copy of Step (Parent Game Object with Children) Transform it 0.2 into y.
        if (ScoreManager.crystalAmount != 0)
        {

            Vector3 newposition = new Vector3(step.transform.position.x, step.transform.position.y + elevationScale, step.transform.position.z);

            Instantiate(step, newposition, Quaternion.identity);

            //spend one crystal
            ScoreManager.crystalAmount--;

            crystalAmountDisplay.text = ScoreManager.crystalAmount.ToString();

            //deactivate box-collider
            //
            //
        }
    }
}
