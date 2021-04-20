using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResistorConnector2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Resistor resistor;
    void Start()
    {
        resistor = transform.parent.GetComponent<Resistor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "BreadboardHoles") {
            resistor.leadInserted(gameObject.name, other.gameObject);
        }
    }
}
