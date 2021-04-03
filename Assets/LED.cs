using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer renderer;

    Column anodeColumn;
    Column cathodeColumn;
    
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (voltage > 2.5f) {
        //    // Debug.Log("Lit");
        // }
        // else if (voltage < 2.5f) {
        //    // Debug.Log("Not Lit");
        // }
    }

    public void leadInserted(string type, GameObject breadboardHole) {
        Debug.Log(type);
        if (type == "Anode") {
            anodeColumn = breadboardHole.gameObject.transform.parent.GetComponent<Column>();
            if (anodeColumn.voltage > 2.5) {
                renderer.material.SetColor("_Color", Color.red);
            }
            else {
                renderer.material.SetColor("_Color", Color.clear);
            }
        }
        if (type == "Cathode") {
            cathodeColumn = breadboardHole.gameObject.transform.parent.GetComponent<Column>();
            cathodeColumn.voltage = anodeColumn.voltage;
        }
    }
}