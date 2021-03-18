using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDSpawner : MonoBehaviour
{


    [SerializeField] private GameObject LED;
    void Start()
    {
        Instantiate(LED, new Vector3(0.6553f, 0.835f, 1.764f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
