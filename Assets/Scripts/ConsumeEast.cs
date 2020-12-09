using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConsumeEast : MonoBehaviour
{

    public GameObject step;

    public int EastDistance;

    public Text crystalAmountDisplay;

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
        if (ScoreManager.crystalAmount != 0)
        {
            //create a copy of Step (Parent Game Object with Children) Transform it 0.2 into y.

            Vector3 newposition = new Vector3(step.transform.position.x + EastDistance, step.transform.position.y, step.transform.position.z);

            Instantiate(step, newposition, Quaternion.identity);

            //spend one crystal
            ScoreManager.crystalAmount--;

            crystalAmountDisplay.text = ScoreManager.crystalAmount.ToString();
        }
    }        
}
