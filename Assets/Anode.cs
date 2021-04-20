using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anode : MonoBehaviour
{
    // Start is called before the first frame update
    public LED LED;
    void Start()
    {
        LED = transform.parent.GetComponent<LED>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "BreadboardHoles") {
            LED.leadInserted(gameObject.name, other.gameObject);
        }
    }
}
