using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ActivateObjectOnClick : MonoBehaviour
{

    public GameObject objectToActivate;

    public AudioSource buildAudio;

    public static int crystalAmount;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        objectToActivate.SetActive(true);
        buildAudio.Play();
    }
}
