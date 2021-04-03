using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cathode : MonoBehaviour
{
    // Start is called before the first frame update
    LED LED;
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
