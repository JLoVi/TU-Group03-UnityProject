using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WaterRaise : MonoBehaviour

{
    public float distancePerSecond;
    public string islandName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is " + islandName);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, distancePerSecond * Time.deltaTime, 0);
    }
}
