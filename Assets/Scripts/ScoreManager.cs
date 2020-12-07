using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int crystalAmount;

    public Text crystalAmountDisplay;

    // Start is called before the first frame update
    void Start()
    {
        crystalAmount = 5;
        crystalAmountDisplay.text = crystalAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
