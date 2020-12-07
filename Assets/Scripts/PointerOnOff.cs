using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PointerOnOff : MonoBehaviour
{

    public GameObject GetPointer;
    // Start is called before the first frame update
    void Start()
    {
        GetPointer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetPointer.SetActive(true);
            StartCoroutine("DisappearShortly");
        }
    }


    IEnumerator DisappearShortly()
    {
        while(true)
        {   
            yield return new WaitForSeconds(1);
            GetPointer.SetActive(false);
        }
    }
}
