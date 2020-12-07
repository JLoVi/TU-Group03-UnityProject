using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrystal : MonoBehaviour
{
    public int crystalAmount;
    
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
        crystalAmount++;
    }
}
