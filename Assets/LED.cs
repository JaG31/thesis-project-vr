using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : MonoBehaviour
{
    // Start is called before the first frame update
    public float voltage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (voltage > 2.5f) {
           // Debug.Log("Lit");
        }
        else if (voltage < 2.5f) {
           // Debug.Log("Not Lit");
        }
    }
}
