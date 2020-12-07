

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalFunctions : MonoBehaviour
{

    public GameObject[] crystals;

    public Text crystalAmountDisplay;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject crystal in crystals)
        {
            crystal.SetActive(false);
        }

        StartCoroutine("GrowingCrystals");
    }

    // Update is called once per frame
    void Update()
    {

    }

    /* void OnMouseDown()
     {

         gameObject.SetActive(false);

         ScoreManager.crystalAmount++;

         crystalAmountDisplay.text = ScoreManager.crystalAmount.ToString();
     }*/

    IEnumerator GrowingCrystals()
    {

        foreach (GameObject crystal in crystals)
        {

            yield return new WaitForSeconds(Random.Range(3, 8));

            crystal.SetActive(true);

        }
    }

}
