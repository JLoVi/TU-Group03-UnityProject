

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
        gameObject.SetActive(false);
        StartCoroutine("GrowingCrystals");
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

    IEnumerator GrowingCrystals()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3,8));
            gameObject.SetActive(true);
        }
    }
}
