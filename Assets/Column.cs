using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float voltage;
    public bool powered;
    private Collider collider;
    private void Start() {
        
    }

    private void Update() {
        if (powered) {
            voltage = 5f;
        }
    }

    public void CollisionDetected(BreadboardHole childScript)
    {
        Debug.Log(this.gameObject.name + "child collided");
    }

    public void PowerColumn(BreadboardHole childScript) {
        powered = true;
        Debug.Log(this.gameObject.name + " is powered");
    }
}
