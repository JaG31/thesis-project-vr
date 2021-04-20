using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryHole : MonoBehaviour
{
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Lead") {
            transform.parent.GetComponent<Battery>().CollisionDetected(this, this.gameObject.name);
        }
    }
}
