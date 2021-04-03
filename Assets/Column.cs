using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float voltage;
    private Collider collider;
    private void Start() {
        
    }

    private void Update() {
        
    }

    public void CollisionDetected(BreadboardHole childScript) {
        //Debug.Log(this.gameObject.name + "child collided");
    }

    public void PowerColumn(BreadboardHole childScript) {
        //Debug.Log(this.gameObject.name + " is powered");
    }
}