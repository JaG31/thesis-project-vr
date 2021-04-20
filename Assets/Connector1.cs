using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Wire wire;
    void Start()
    {
        wire = transform.parent.GetComponent<Wire>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "BreadboardHoles") {
            wire.leadInserted(gameObject.name, other.gameObject);
        }
    }
}
