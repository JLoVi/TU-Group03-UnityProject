using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCrystal : MonoBehaviour
{
    public Text crystalAmountDisplay;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        ScoreManager.crystalAmount++;

        crystalAmountDisplay.text = ScoreManager.crystalAmount.ToString();
    }
}
