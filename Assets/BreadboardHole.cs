using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadboardHole : MonoBehaviour
{
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Lead") {
            transform.parent.GetComponent<Column>().CollisionDetected(this);
        }

        if (other.gameObject.tag == "Power") {
            transform.parent.GetComponent<Column>().PowerColumn(this);
        }
    }
}
