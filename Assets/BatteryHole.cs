using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryHole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Lead") {
            transform.parent.GetComponent<Battery>().CollisionDetected(this, this.gameObject.name, other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Lead") {
            transform.parent.GetComponent<Battery>().CollisionUnDetected(this, this.gameObject.name, other.gameObject);
        }
    }
}
