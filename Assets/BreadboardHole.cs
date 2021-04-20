using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadboardHole : MonoBehaviour
{
    public GameObject collided;
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Lead") {
            collided = other.gameObject;
            transform.parent.GetComponent<Column>().CollisionDetected(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Lead") {
            collided = null;
            transform.parent.GetComponent<Column>().CollisionUnDetected(other.gameObject);
        }
    }
}
